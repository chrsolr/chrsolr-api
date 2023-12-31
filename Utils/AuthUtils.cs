using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class AuthUtils
{
    public static (string, string) CreatePasswordHash(string password)
    {
        using (var hmac = new HMACSHA256())
        {
            var salt = hmac.Key;
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            return (Convert.ToBase64String(hash, 0, hash.Length),
                    Convert.ToBase64String(salt, 0, salt.Length));
        }
    }

    public static bool VerifyPassword(string password, string passwordHash, string passwordSalt)
    {
        var decodedHash = Convert.FromBase64String(passwordHash);
        var decodedSalt = Convert.FromBase64String(passwordSalt);

        using (var hmac = new HMACSHA256(decodedSalt))
        {
            byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            return hash.SequenceEqual(decodedHash);
        }
    }

    public static string GenerateToken(User user)
    {
        var jwtKey = Environment.GetEnvironmentVariable("JWT_KEY");
        var issuer = Environment.GetEnvironmentVariable("JWT_ISSUER");
        var audience = Environment.GetEnvironmentVariable("JWT_AUDIENCE");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

        List<Claim> claims = new List<Claim>{
            new Claim(ClaimTypes.Name, user.Username),
            new Claim(ClaimTypes.Email, user.Email)
        };

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            issuer: issuer,
            audience: audience,
            signingCredentials: creds
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public static string AesEncrypt(string plainText, byte[] key, byte[] iv)
    {
        Aes encryptor = Aes.Create();
        encryptor.Mode = CipherMode.CBC;

        byte[] aesKey = new byte[32];
        Array.Copy(key, 0, aesKey, 0, 32);

        encryptor.Key = aesKey;
        encryptor.IV = iv;

        MemoryStream memoryStream = new MemoryStream();

        ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();
        CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

        byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
        cryptoStream.FlushFinalBlock();

        byte[] cipherBytes = memoryStream.ToArray();

        memoryStream.Close();
        cryptoStream.Close();

        return Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);
    }

    public static string AesDecrypt(string cipherText, byte[] key, byte[] iv)
    {
        Aes encryptor = Aes.Create();
        encryptor.Mode = CipherMode.CBC;

        byte[] aesKey = new byte[32];
        Array.Copy(key, 0, aesKey, 0, 32);

        encryptor.Key = aesKey;
        encryptor.IV = iv;

        MemoryStream memoryStream = new MemoryStream();

        ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();
        CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

        string plainText = String.Empty;

        try
        {
            byte[] cipherBytes = Convert.FromBase64String(cipherText);

            cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
            cryptoStream.FlushFinalBlock();

            byte[] plainBytes = memoryStream.ToArray();
            plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
        }
        finally
        {
            memoryStream.Close();
            cryptoStream.Close();
        }

        return plainText;
    }
}

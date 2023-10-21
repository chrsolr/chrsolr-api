using System.Security.Cryptography;
using System.Text;

public class AES
{
    public static string Encrypt(string plainText, byte[] key, byte[] iv)
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

    public static string Decrypt(string cipherText, byte[] key, byte[] iv)
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

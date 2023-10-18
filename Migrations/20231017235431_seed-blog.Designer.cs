﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using chrsolr_api.Data;

#nullable disable

namespace chrsolr_api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231017235431_seed-blog")]
    partial class seedblog
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Markdown")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2f9a0a78-7c3c-467e-a66e-ab3a728d50e0"),
                            CreatedAt = new DateTime(2023, 10, 17, 23, 54, 30, 952, DateTimeKind.Utc).AddTicks(7606),
                            ImageUrl = "https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8",
                            IsActive = true,
                            Markdown = "![](https://media.licdn.com/dms/image/C4D12AQGVVggsU6DJmQ/article-cover_image-shrink_423_752/0/1520153484632?e=1684972800&v=beta&t=nUDHhz9VY50Mr5UNCu26xSNSy7k7Y1AoLazNlPaW3G8)\n# CoderCamps Bootcamp as a Student\n\nI know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.\n\n### About me\nAt age 29 I decided to get my G.E.D and go to college. I always loved computers, so choosing Information Technology was a no brainer. While working towards my degree I was introduced to an introductory C++ class. After that class all I wanted to do was programming. Since I also loved messing around with cellphones, I decided to learn more about mobile development. During the time I had a Windows Phone 7 cellphone. I started teaching myself C# and created my first application, a simple calculator.\n\nShortly after finishing my associate degree in Information Technology; I relocated to Rhode Island to pursue a Bachelors in Computer Science. The programming language taught in Rhode Island College was JAVA. Because of this and my love for mobile development, I started learning about Android Development. While at Rhode Island College I took a Software Engineer class where I built an app to find restaurants locally. I also designed an Xbox One Achievement tracker called  [Xchievements](https://www.youtube.com/watch?v=Sb2X2VhuPgY).\n\nBefore I could finish my degree I relocated once again to Houston, TX. My intentions were to find a job in the programming field. One day I saw a commercial about a programming Bootcamp advertising “Earn an average of $70k after graduation.” My first thought was “That’s BS”. But, I thought about it and decided to visit the school to get more information. My first impression was not great. I got an “it’s all bout business” vibe. After a week and much thinking and debating I decided to go.\n\n### Bootcamp time!\nSince I already had a programming background, I knew camp was not going to be as hard for me as my fellow classmates. Yes, I didn’t know anything about HTML, CSS3, JavaScript or anything that had to do with the web. But after being around and hearing so much programming you start picking up stuff quicker. I also had a month to prepare before the start of camp.\n\nAt the time, the camp was divided into three phases. Throughout all the different phases we built small applications imitating Facebook, Twitter and full CRUD (Create, Read, Update, Delete) applications. Below is a breakdown of the structure while I attended camp:\n\n#### Week 1-3\n-   HTML5\n-   CSS3\n-   JavaScript\n-   AngularJS\n\n#### Week 4-6\n-   C#\n-   ASP.NET MVC\n-   SQL Server\n-   Entity Framework\n-   Repository Pattern\n-   Web API\n-   Authentication\n\n#### Week 7-9\n-   Small group project\n-   Project inherited from previous group\n-   Individual project\n\n### Phase 1\n\nAt first, I was nervous to meet people as passionate as me about programming; as I was never surrounded by that type of environment while in college. Right away I knew everyone was there to learn. Of course, there were some personality issues between fellow students, including me; you just cannot have a bunch of people in a stressful environment without having some issues. The instructor was great. He could teach a caveman how to program, seriously. It was like he knew every form of making people learn.\n\nThe month I had to prepare really helped with HTML and CSS and the transition from an OOP language to JavaScript was seamless. In the other hand, I struggled getting my head around AngularJS. I was like “What the F*** is? Dependency Injection, Directives, Controllers and Services.” It was not a How? Question, but a Why? Question. So, I started to do my work as fast as I could and learned more about AngularJS. By the end of the first phase we got to know each other better, and everyone was getting on the same page.\n\n![](https://media.licdn.com/dms/image/C4D12AQEswgMFBdKamQ/article-inline_image-shrink_1500_2232/0/1520066214987?e=1684972800&v=beta&t=3djMkcY5F8jW39BgcZZ8hbE6yJwHJVAbU2IinxOGcLc)\n\n![](https://media.licdn.com/dms/image/C4D12AQEufCZ0uNH41A/article-inline_image-shrink_1500_2232/0/1520237234918?e=1684972800&v=beta&t=mo5y-t6YQtt-RL9QVEtbywantq5rPrR1TuaQwjPeTLA)\n\n### Phase 2\n\nThe second phase of the program was a little different. Thanks to my previous knowledge in OOP, the first week went smoothly. I took this opportunity and learned more about AngularJS and Twitter Bootstrap. I also helped my classmates understand C# and the OOP fundamentals. As we moved to ASP.NET, the pace picked up and things started getting overwhelming. I understood the classes but I would forget by the next day because we were being introduced to new logics everyday. I used my weekends to review everything we covered during the week.\n\nBy the third week most of the group had bonded. In our free time we played Jenga, went to lunch and solved programming problems together.\n\n![](https://media.licdn.com/dms/image/C4D12AQE57CN6jRM4Qg/article-inline_image-shrink_1500_2232/0/1520195237364?e=1684972800&v=beta&t=DvXIc3exMppjsUQFRV26eS2n9v9v8T6DRtkPOBemLQE)\n\n![](https://media.licdn.com/dms/image/C4D12AQHl0cUSNXi7gw/article-inline_image-shrink_1500_2232/0/1520063087886?e=1684972800&v=beta&t=CGJWeDaLZuyw5fuprqSdY9Lo3ZhqBqsJ_3KBIwnibx0)\n\n### Phase 3\n\nI feel like the third phase was where I learned the most. Not because I learned new skills, but because I got to use all the previous knowledge I learned at camp. During this phase we also got a chance to experience what to expect in the workplace. We needed to log our progress, complete tasks during given time and report all things to the staff, which pretended to be the client.\n\n![](https://media.licdn.com/dms/image/C4D12AQEGwZz6VuoIeQ/article-inline_image-shrink_1500_2232/0/1520040451164?e=1684972800&v=beta&t=PE3tTDYnDWdRoCAvtE7JRdmLhHMi0ZiKhEzCWZqFP6I)\n\n#### The Good\n\n-   Meet people with common passions\n-   Learn how others may solve a problem in a different way\n-   Learn plenty of information in a short time (This can be a bit stressful)\n-   Get help from real people and not my best friend stackoverflow.com\n-   Great environment\n\n#### The Bad\n\n-   This type of programming Bootcamp is not for everyone. It is pretty hard to get a grasp on programming in just 9 weeks with out prior knowledge. However it can be done.\n-   Do not go to Bootcamp for the wrong reasons. Remember that you are paying for this. If you are not willing to absorb everything you are taught, you wont get your moneys worth.\n-   Expanding on my previous bullet. Do not attend camp because you want a job or a great salary. To be a developer is not about knowing the syntax of a programming language. It is about taking a problem and figuring out how to solve it. You might think learning the basics will get you in the door. However if you don’t know how to brake down a problem, translate it to code and solve it efficiently, then you wont last long.\n\n### Overall\n\nCoding Bootcamp is good for people that want to learn programming or expand their knowledge, but only if they are incredibly passionate about it. Even though the boot camp staff wants you to succeed, it is all about your willingness to learn.\n\nThank you for reading.",
                            Slug = "codercamps-bootcamp-as-a-student",
                            Summary = "I know plenty of people are looking into all these different programming Bootcamps. Since I attended one, I would like to share my opinion. I will start by talking about myself, and my programming experience prior to the camp. In addition I will share information about the structure of the camp during my time there.",
                            Title = "CoderCamps Bootcamp as a Student",
                            UpdatedAt = new DateTime(2023, 10, 17, 23, 54, 30, 952, DateTimeKind.Utc).AddTicks(7606),
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        });
                });

            modelBuilder.Entity("Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bea34179-8969-4115-9c30-9302dfe04bd0"),
                            Description = "9 Week .NET Full Stack Program, 8/2014",
                            Location = "Coder Camps, Pearland, TX",
                            Order = 1,
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("a1637c67-d666-45c1-9db5-12e7a30b2b0e"),
                            Description = "Bachelor's Degree in Computer Science, (78 Credits)",
                            Location = "Rhode Island College, Providence, RI",
                            Order = 2,
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("f9564b98-cf57-4f27-be58-729629face2a"),
                            Description = "Associate Degree in Applied Science in Information Technology, 08/2011",
                            Location = "Monroe College, Bronx, NY",
                            Order = 3,
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        });
                });

            modelBuilder.Entity("Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            CompanyName = "Innowatts Inc",
                            EndDate = "Present",
                            StartDate = "February 2018",
                            Title = "Full Stack Developer",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            CompanyName = "Preventice Solutions",
                            EndDate = "June 2017",
                            StartDate = "August 2015",
                            Title = "Jr. Software Engineer",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            CompanyName = "Coder Camps",
                            EndDate = "March 2015",
                            StartDate = "September 2014",
                            Title = "Jr. Web Developer/Teacher Assistants",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        });
                });

            modelBuilder.Entity("Responsibility", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Responsibilities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d5f07050-0729-4bec-9bec-496682c607d6"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB."
                        },
                        new
                        {
                            Id = new Guid("dbdae67d-58f1-4d52-acf4-92b0b41ec28b"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Decouple codebase and built components make the code reusable."
                        },
                        new
                        {
                            Id = new Guid("9af45af4-d934-4a4f-a897-51cb50e98225"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach."
                        },
                        new
                        {
                            Id = new Guid("e367b2d9-b41a-443a-9e16-47991a4094f7"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Deploy dockerized applications to Kubernetes via Helm charts."
                        },
                        new
                        {
                            Id = new Guid("871eff56-e823-48f3-af27-0418532908bf"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET."
                        },
                        new
                        {
                            Id = new Guid("f72cc700-53ca-410f-b1c7-8d94d1baa3df"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern."
                        },
                        new
                        {
                            Id = new Guid("775eea79-b6be-4b94-ad3f-13f64e6c3d87"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "Imported and improved legacy code from older applications into an ASP.NET MVC application."
                        },
                        new
                        {
                            Id = new Guid("84208db9-dd6c-4cb8-ab24-7ffb6793e85a"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "Improved and modularized a highly customizable User Interface."
                        },
                        new
                        {
                            Id = new Guid("d8583131-7321-4046-a54f-46e362e3b4b6"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML."
                        },
                        new
                        {
                            Id = new Guid("e721543c-1541-42fa-98f4-240178464343"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS."
                        },
                        new
                        {
                            Id = new Guid("eb5f43c6-1e42-4e34-9015-b05b9e5782dd"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "Implemented features where students can apply for a “partner’s” job through a website."
                        },
                        new
                        {
                            Id = new Guid("68c3d442-9b76-4792-9f4f-6273182241c0"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "Managed and led a team of 5-7 interns on daily assignments."
                        });
                });

            modelBuilder.Entity("Social", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Socials");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ac0fef8-fc58-437a-ac88-3336a8512e20"),
                            IsActive = true,
                            Name = "Github",
                            Url = "https://github.com/chrsolr/",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("51ad4f41-4388-462d-b027-77c3dcb24641"),
                            IsActive = true,
                            Name = "LinkedIn",
                            Url = "https://www.linkedin.com/in/christiansoler/",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("136bdd58-17da-4a82-ba6d-a6b6291f25b4"),
                            IsActive = true,
                            Name = "Codepen",
                            Url = "https://codepen.io/chrsolr",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("7e6146c3-b20b-4313-8073-28dda3ef6396"),
                            IsActive = true,
                            Name = "Instagram",
                            Url = "https://www.instagram.com/7w3n7y/",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("0a3ddecb-00d0-48a4-8c1f-9aa3e7eb2720"),
                            IsActive = false,
                            Name = "Twitch",
                            Url = "https://www.twitch.tv/7w3n7y",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        },
                        new
                        {
                            Id = new Guid("5d13d1cd-5629-4a62-9eac-5e7fe58011b4"),
                            IsActive = false,
                            Name = "YouTube",
                            Url = "https://www.youtube.com/@chrsolr",
                            UserId = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8")
                        });
                });

            modelBuilder.Entity("Technology", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Technologies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53eef55b-75b7-4aad-a6ce-8ca214346f0d"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "AngularJs"
                        },
                        new
                        {
                            Id = new Guid("0c05a991-2aad-4b29-a63d-160372a1e4d7"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "ReactJs"
                        },
                        new
                        {
                            Id = new Guid("3131dcee-edb3-4cb6-9717-5c30b79bf543"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Styled Components"
                        },
                        new
                        {
                            Id = new Guid("8321de27-eb1f-44c7-9607-806bea16b7f6"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Typescript"
                        },
                        new
                        {
                            Id = new Guid("31a78798-a116-4103-a9f8-964f1b7c7beb"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "NodeJs"
                        },
                        new
                        {
                            Id = new Guid("2714a860-7b9a-40f5-a11d-c564280bf4f3"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "MeteorJs"
                        },
                        new
                        {
                            Id = new Guid("b8a16ce6-c8d4-44ce-b0ed-41c20258f403"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "MongoDB"
                        },
                        new
                        {
                            Id = new Guid("5f95d8c8-111c-464f-b592-40c1d108f090"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Docker"
                        },
                        new
                        {
                            Id = new Guid("5852fa0e-ffb9-49f8-a700-71670177d101"),
                            JobId = new Guid("8b6e59b5-e31c-49c4-b1b6-5e2eb3cc8a32"),
                            Name = "Kubernetes"
                        },
                        new
                        {
                            Id = new Guid("5080a04a-4ada-437d-9495-a050c60a5951"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("b6148f03-0fdf-469a-9873-a4c043490c75"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "ASP.NET MVC"
                        },
                        new
                        {
                            Id = new Guid("7d737e4b-93df-4532-b7f3-b41a536a299e"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("a7f32058-7d2f-4d0e-841f-cb7829a7807c"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "KnockoutJs"
                        },
                        new
                        {
                            Id = new Guid("2149cc68-b052-4071-bf1f-118e87931180"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "RequireJs"
                        },
                        new
                        {
                            Id = new Guid("0fa66b11-a934-447a-992c-342f09a36d83"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "Entity Framework"
                        },
                        new
                        {
                            Id = new Guid("04ea6260-d3cb-4249-aa72-1f17ec475a62"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "AJAX"
                        },
                        new
                        {
                            Id = new Guid("64c537f3-7e85-444e-98d5-328b889be279"),
                            JobId = new Guid("fe9bb8f1-2efa-4611-93f8-6b48912384ba"),
                            Name = "MS SQL"
                        },
                        new
                        {
                            Id = new Guid("c731f586-ec41-497b-8cda-5cb84203febe"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("40cd201d-a2f6-4833-ab75-e72171517b71"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "ASP.NET MVC"
                        },
                        new
                        {
                            Id = new Guid("8c5d239b-823b-44d2-985b-8dc27600426c"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "AngularJs"
                        },
                        new
                        {
                            Id = new Guid("9c3197c6-612f-4592-a89d-a898c08762ad"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "MS SQL"
                        },
                        new
                        {
                            Id = new Guid("c08216f0-f706-45b3-a674-9ac4fe78f2a2"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "AJAX"
                        },
                        new
                        {
                            Id = new Guid("20dc776a-2816-4715-8a4b-cd6d9064f65e"),
                            JobId = new Guid("7688d14b-5140-4206-9132-8a3cec8e0ced"),
                            Name = "LINQ"
                        });
                });

            modelBuilder.Entity("chrsolr_api.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ca4b089-8feb-4017-857a-b0129948a0c8"),
                            CreatedAt = new DateTime(2023, 10, 17, 23, 54, 30, 952, DateTimeKind.Utc).AddTicks(7622),
                            Email = "chr.solr@gmail.com",
                            FirstName = "Christian",
                            ImageUrl = "https://i.imgur.com/9X6lkc5.jpg",
                            LastName = "Soler",
                            NickName = "Chrsolr",
                            Password = "",
                            UpdatedAt = new DateTime(2023, 10, 17, 23, 54, 30, 952, DateTimeKind.Utc).AddTicks(7622),
                            Username = "chrsolr"
                        });
                });

            modelBuilder.Entity("BlogPost", b =>
                {
                    b.HasOne("chrsolr_api.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Education", b =>
                {
                    b.HasOne("chrsolr_api.Models.User", "User")
                        .WithMany("Educations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Job", b =>
                {
                    b.HasOne("chrsolr_api.Models.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Responsibility", b =>
                {
                    b.HasOne("Job", "Job")
                        .WithMany("Responsibilities")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Social", b =>
                {
                    b.HasOne("chrsolr_api.Models.User", "User")
                        .WithMany("Socials")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Technology", b =>
                {
                    b.HasOne("Job", "Job")
                        .WithMany("Technologies")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("Job", b =>
                {
                    b.Navigation("Responsibilities");

                    b.Navigation("Technologies");
                });

            modelBuilder.Entity("chrsolr_api.Models.User", b =>
                {
                    b.Navigation("Educations");

                    b.Navigation("Jobs");

                    b.Navigation("Socials");
                });
#pragma warning restore 612, 618
        }
    }
}
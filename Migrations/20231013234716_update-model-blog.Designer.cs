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
    [Migration("20231013234716_update-model-blog")]
    partial class updatemodelblog
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlogPost", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Markdown")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AboutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9035894d-79ee-4a06-ae94-c946de6e5d5b"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            Description = "9 Week .NET Full Stack Program, 8/2014",
                            Location = "Coder Camps, Pearland, TX",
                            Order = 1
                        },
                        new
                        {
                            Id = new Guid("fdc6e30f-b94a-4bd1-a556-7a340a474d55"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            Description = "Bachelor's Degree in Computer Science, (78 Credits)",
                            Location = "Rhode Island College, Providence, RI",
                            Order = 2
                        },
                        new
                        {
                            Id = new Guid("cf3097b5-04f6-4592-a9e2-94fa2253b8fd"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            Description = "Associate Degree in Applied Science in Information Technology, 08/2011",
                            Location = "Monroe College, Bronx, NY",
                            Order = 3
                        });
                });

            modelBuilder.Entity("Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AboutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            CompanyName = "Innowatts Inc",
                            EndDate = "Present",
                            StartDate = "February 2018",
                            Title = "Full Stack Developer"
                        },
                        new
                        {
                            Id = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            CompanyName = "Preventice Solutions",
                            EndDate = "June 2017",
                            StartDate = "August 2015",
                            Title = "Jr. Software Engineer"
                        },
                        new
                        {
                            Id = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            CompanyName = "Coder Camps",
                            EndDate = "March 2015",
                            StartDate = "September 2014",
                            Title = "Jr. Web Developer/Teacher Assistants"
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Responsibilities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("68a81a48-f960-492a-bdfe-bf127407957a"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Built Web APIs with NodeJS, ExpressJS, Postgres, and MongoDB."
                        },
                        new
                        {
                            Id = new Guid("e54d77e7-bcc8-4419-b39b-b9977dc81de9"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Decouple codebase and built components make the code reusable."
                        },
                        new
                        {
                            Id = new Guid("0613668e-8ff6-4d96-8b9f-3ee9f3b69b00"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Build a RESTful API that communicates with various external RESTful & SOAP APIs utilizing a Microservice approach."
                        },
                        new
                        {
                            Id = new Guid("505df7f4-256a-4653-9966-696c010b0b83"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Deploy dockerized applications to Kubernetes via Helm charts."
                        },
                        new
                        {
                            Id = new Guid("e8c303a1-9e48-4d70-8e72-918f7a4b3875"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "Created JavaScript Modules from existing code using KnockoutJs, RequireJs, and ASP.NET."
                        },
                        new
                        {
                            Id = new Guid("82cf9ed3-aa70-4e42-a6a1-4b7a3a26e1d3"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "Find, Document, and implement design patterns such as Dependency Injection and Repository Pattern."
                        },
                        new
                        {
                            Id = new Guid("f7fd48a6-6282-44ac-af08-56f4ec2356bb"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "Imported and improved legacy code from older applications into an ASP.NET MVC application."
                        },
                        new
                        {
                            Id = new Guid("1a4ea392-73a4-44ad-9d4e-eca418e2f49b"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "Improved and modularized a highly customizable User Interface."
                        },
                        new
                        {
                            Id = new Guid("5346255d-13c2-47b7-a76b-c18d477e08ae"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "Re-designed the company’s website and layouts utilizing Razor Engine, Bootstrap, LESS CSS, JQuery, and HTML."
                        },
                        new
                        {
                            Id = new Guid("b2a15d15-2ba6-427a-a9f5-c9f7e7d82625"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "Designed and Implemented the “partner” section on the company's website using C# ASP.NET, MVC, Entity Framework, LINQ, Razor Engine, and AngularJS."
                        },
                        new
                        {
                            Id = new Guid("a1990bd7-41f0-4b93-acbf-a2ae54e3ab1b"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "Implemented features where students can apply for a “partner’s” job through a website."
                        },
                        new
                        {
                            Id = new Guid("92f77ca3-645c-4382-9586-a37078744526"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "Managed and led a team of 5-7 interns on daily assignments."
                        });
                });

            modelBuilder.Entity("Social", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AboutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("Socials");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fbb49925-2b20-47e4-a8ef-58945d869ae7"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            IsActive = true,
                            Name = "Github",
                            Url = "https://github.com/chrsolr/"
                        },
                        new
                        {
                            Id = new Guid("6260d5c7-fbf4-475e-930f-283df8050cd2"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            IsActive = true,
                            Name = "LinkedIn",
                            Url = "https://www.linkedin.com/in/christiansoler/"
                        },
                        new
                        {
                            Id = new Guid("abfab7f2-302b-4e44-870e-4b6e2ba36b92"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            IsActive = true,
                            Name = "Codepen",
                            Url = "https://codepen.io/chrsolr"
                        },
                        new
                        {
                            Id = new Guid("98704d67-b9c6-482f-a07b-239afb82dfc9"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            IsActive = true,
                            Name = "Instagram",
                            Url = "https://www.instagram.com/7w3n7y/"
                        },
                        new
                        {
                            Id = new Guid("30ebe14e-a526-4e14-9eaa-3eafaa38c5fb"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            IsActive = false,
                            Name = "Twitch",
                            Url = "https://www.twitch.tv/7w3n7y"
                        },
                        new
                        {
                            Id = new Guid("aca545e4-6ae5-44bf-a8ef-10346e414147"),
                            AboutId = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            IsActive = false,
                            Name = "YouTube",
                            Url = "https://www.youtube.com/@chrsolr"
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Technologies");

                    b.HasData(
                        new
                        {
                            Id = new Guid("93644cd6-eb36-4206-b9a1-ab5064a6cb3f"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "AngularJs"
                        },
                        new
                        {
                            Id = new Guid("162e029d-1cfb-4b38-adc3-4d66e8d97041"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "ReactJs"
                        },
                        new
                        {
                            Id = new Guid("5075af85-7bcf-41e6-8d0b-21ce57a876de"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Styled Components"
                        },
                        new
                        {
                            Id = new Guid("87bebf78-cd0e-45e5-b2a7-b5377e148b73"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Typescript"
                        },
                        new
                        {
                            Id = new Guid("23dbe259-1c50-4536-96c5-1441e846d3fd"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "NodeJs"
                        },
                        new
                        {
                            Id = new Guid("cd8410a0-895a-42b5-8d40-fbe13bc61b61"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "MeteorJs"
                        },
                        new
                        {
                            Id = new Guid("19a81f1e-3c20-40ed-86bc-ecfd6c330ed2"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "MongoDB"
                        },
                        new
                        {
                            Id = new Guid("ee51a38f-fed0-4a50-bf98-042f4c1083cd"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Docker"
                        },
                        new
                        {
                            Id = new Guid("ffbdb110-e77e-44a9-acea-9e37f937ad02"),
                            JobId = new Guid("44b370de-4d8b-4960-bd17-f1955d73ac23"),
                            Name = "Kubernetes"
                        },
                        new
                        {
                            Id = new Guid("5fcd6db3-24e9-4e61-8386-f9061261225d"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("bf8ecedb-2568-49e6-8190-c620283891d9"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "ASP.NET MVC"
                        },
                        new
                        {
                            Id = new Guid("492d10a9-4e0f-4b87-ae91-472695f01f68"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = new Guid("c947a6a1-ae13-45c6-bc00-d5d2eb79aa07"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "KnockoutJs"
                        },
                        new
                        {
                            Id = new Guid("4a857958-511c-43f9-8ee7-7210e52ef92c"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "RequireJs"
                        },
                        new
                        {
                            Id = new Guid("961bdb88-49e4-40c8-87bd-1703ab1f44ab"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "Entity Framework"
                        },
                        new
                        {
                            Id = new Guid("c2ce192a-5a70-4798-8d1a-52a688992410"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "AJAX"
                        },
                        new
                        {
                            Id = new Guid("5c7c0f66-5b7b-4ac1-8102-17d1ecda43de"),
                            JobId = new Guid("54ed56bc-f88f-42bb-aaf4-9ab47e580963"),
                            Name = "MS SQL"
                        },
                        new
                        {
                            Id = new Guid("472a06ac-31dc-477e-8752-fd3d2fa01e13"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "C#"
                        },
                        new
                        {
                            Id = new Guid("188d64a1-fab0-4fcf-8a7d-4ef13af1d4ad"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "ASP.NET MVC"
                        },
                        new
                        {
                            Id = new Guid("d9bb43ec-6a91-442b-9cae-4eb6683c8201"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "AngularJs"
                        },
                        new
                        {
                            Id = new Guid("23907a29-22a7-4feb-ae5b-724751af3626"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "MS SQL"
                        },
                        new
                        {
                            Id = new Guid("edb849fa-8163-4fea-90b1-f8255dfa47cd"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "AJAX"
                        },
                        new
                        {
                            Id = new Guid("db377a53-2f5b-47dd-9ed0-9b637f1be4e0"),
                            JobId = new Guid("4056004b-f63f-4367-a979-dfd709084b92"),
                            Name = "LINQ"
                        });
                });

            modelBuilder.Entity("chrsolr_api.Models.About", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AboutId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AboutId");

                    b.ToTable("About");

                    b.HasData(
                        new
                        {
                            Id = new Guid("05d06a42-5450-4afe-8932-bac5c3ea3cab"),
                            Email = "chr.solr@gmail.com",
                            FirstName = "Christian",
                            ImageUrl = "https://i.imgur.com/9X6lkc5.jpg",
                            LastName = "Soler",
                            NickName = "Chrsolr"
                        });
                });

            modelBuilder.Entity("Education", b =>
                {
                    b.HasOne("chrsolr_api.Models.About", "About")
                        .WithMany("Educations")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("About");
                });

            modelBuilder.Entity("Job", b =>
                {
                    b.HasOne("chrsolr_api.Models.About", "About")
                        .WithMany("Jobs")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("About");
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
                    b.HasOne("chrsolr_api.Models.About", "About")
                        .WithMany("Socials")
                        .HasForeignKey("AboutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("About");
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

            modelBuilder.Entity("chrsolr_api.Models.About", b =>
                {
                    b.HasOne("chrsolr_api.Models.About", null)
                        .WithMany("AboutMe")
                        .HasForeignKey("AboutId");
                });

            modelBuilder.Entity("Job", b =>
                {
                    b.Navigation("Responsibilities");

                    b.Navigation("Technologies");
                });

            modelBuilder.Entity("chrsolr_api.Models.About", b =>
                {
                    b.Navigation("AboutMe");

                    b.Navigation("Educations");

                    b.Navigation("Jobs");

                    b.Navigation("Socials");
                });
#pragma warning restore 612, 618
        }
    }
}
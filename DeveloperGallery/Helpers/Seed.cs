using DeveloperGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperGallery.Helpers
{
    public static class Seed
    {
        public static ICollection<User> Users { get; set; }
        public static ICollection<Project> Projects { get; set; }
        public static ICollection<Tag> Tags { get; set; }

        public static void InitData()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Abdulahh",
                    LastName = "Khteeb",
                    BirthDate = new DateTime(1997, 5, 13),
                    ImageUrl = @"../Images/MyPhoto.jpg",
                    Emails = new List<Email>()
                        {
                            new Email()
                            {
                                Id = 1,
                                EmailAddress = "AbduKhteeb7@Hotmail.com"
                            },
                            new Email()
                            {
                                Id = 2,
                                EmailAddress = "AbduKhteeb7@Gmail.com"
                            }
                        },
                    Phones = new List<Phone>()
                        {
                            new Phone()
                            {
                                Id = 1,
                                PhoneNumber = "0956746343"
                            },
                            new Phone()
                            {
                                Id = 2,
                                PhoneNumber = "0967783095"
                            }
                        },
                    UserName = "AbduKhteeb7",
                    Password = "00000000"
                },

            };

            Projects = new List<Project>()
            {
                new Project()
                {
                    Id = 1,
                    Title = "Project 1",
                    Description = "This is demo for developers ,This is demo for developers ," +
                    "This is demo for developers ,This is demo for developers ," +
                    "This is demo for developers ,This is demo for developers ," +
                    "This is demo for developers ,This is demo for developers ," +
                    "This is demo for developers ,This is demo for developers",
                    ImageUrl = @"../Images/ProjectImage1.jpg",
                    PostingDate = DateTime.Now,
                    Author = Users.First(),
                    Tags = new List<Tag>()
                    {
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp"
                        },
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp 4.1.3"
                        },
                        new Tag()
                        {
                            Id = 2,
                            Name = "JQuery"
                        },
                        new Tag()
                        {
                            Id = 3,
                            Name = "Website"
                        },
                    }
                },
                new Project()
                {
                    Id = 2,
                    Title = "Project 2",
                    Description = "This is demo for developers",
                    ImageUrl = @"../Images/ProjectImage3.png",
                    PostingDate = DateTime.Now,
                    Author = Users.First(),
                    Tags = new List<Tag>()
                    {
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp"
                        },
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp 4.1.3"
                        },
                        new Tag()
                        {
                            Id = 2,
                            Name = "JQuery"
                        },
                        new Tag()
                        {
                            Id = 3,
                            Name = "Website"
                        },
                    }
                },
                new Project()
                {
                    Id = 3,
                    Title = "Project 3",
                    Description = "This is demo for developers",
                    ImageUrl = @"../Images/ProjectImage4.jpg",
                    PostingDate = DateTime.Now,
                    Author = Users.First(),
                    Tags = new List<Tag>()
                    {
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp"
                        },
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp 4.1.3"
                        },
                        new Tag()
                        {
                            Id = 2,
                            Name = "JQuery"
                        },
                        new Tag()
                        {
                            Id = 3,
                            Name = "Website"
                        },
                    }
                },
                new Project()
                {
                    Id = 4,
                    Title = "Project 4",
                    Description = "This is demo for developers",
                    ImageUrl = @"../Images/ProjectImage1.jpg",
                    PostingDate = DateTime.Now,
                    Author = Users.First(),
                    Tags = new List<Tag>()
                    {
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp"
                        },
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp 4.1.3"
                        },
                        new Tag()
                        {
                            Id = 2,
                            Name = "JQuery"
                        },
                        new Tag()
                        {
                            Id = 3,
                            Name = "Website"
                        },
                    }
                },
                new Project()
                {
                    Id = 5,
                    Title = "Project 5",
                    Description = "This is demo for developers",
                    ImageUrl = @"../Images/ProjectImage3.png",
                    PostingDate = DateTime.Now,
                    Author = Users.First(),
                    Tags = new List<Tag>()
                    {
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp"
                        },
                        new Tag()
                        {
                            Id = 1,
                            Name = "Bootstarp 4.1.3"
                        },
                        new Tag()
                        {
                            Id = 2,
                            Name = "JQuery"
                        },
                        new Tag()
                        {
                            Id = 3,
                            Name = "Website"
                        },
                    }
                },

            };

            Tags = new List<Tag>()
            {
                new Tag
                {
                    Name = "Bootstrap"
                },
                new Tag
                {
                    Name = "C#"
                },
                new Tag
                {
                    Name = "ASP.Net Core"
                },
                new Tag
                {
                    Name = "MVC"
                },
                new Tag
                {
                    Name = "HTML"
                },
                new Tag
                {
                    Name = "CSS"
                },
                new Tag
                {
                    Name = "Javascript"
                },
                new Tag
                {
                    Name = "JQuery"
                },
                new Tag
                {
                    Name = "SQL"
                },
            };
        }
    }
}

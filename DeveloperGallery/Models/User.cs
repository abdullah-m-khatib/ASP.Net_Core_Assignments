using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperGallery.Models
{
    public class User
    {
        public User()
        {
            Emails = new HashSet<Email>();
            Phones = new HashSet<Phone>();
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Email> Emails { get; set; }
        public ICollection<Phone> Phones { get; set; }

        public ICollection<Project> Projects { get; set; }
    }

    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }

    public class Email
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}

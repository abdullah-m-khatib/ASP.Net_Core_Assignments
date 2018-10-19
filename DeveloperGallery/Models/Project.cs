using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperGallery.Models
{
    public class Project
    {
        public Project()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public DateTime PostingDate { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}

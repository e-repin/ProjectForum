using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Post
    {
        public Post()
        {
            Comments = new List<Comment>();
            Categories = new List<Category>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public ApplicationUser User { get; set; }
        public string UserId { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<Comment> Comments { get; set; }               

    }
}

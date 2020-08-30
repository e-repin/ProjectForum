using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class PostModel
    {
        public PostModel()
        {
            Comments = new List<CommentModel>();
            Categories = new List<CategoryModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public ApplicationUserModel User { get; set; }
        public string UserId { get; set; }

        public ICollection<CategoryModel> Categories { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
    }
}

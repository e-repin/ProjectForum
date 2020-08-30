using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class CommentModel
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public ApplicationUserModel User { get; set; }
        public string UserId { get; set; }
        public PostModel Post { get; set; }
        public int PostId { get; set; }
    }
}

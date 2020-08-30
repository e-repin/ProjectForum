using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class CategoryModel
    {
        public CategoryModel()
        {
            Posts = new List<PostModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<PostModel> Posts { get; set; }

    }
}

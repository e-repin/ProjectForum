using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IPostManager
    {
        void AddPost(PostModel postModel);
        void CreatePost(PostModel postModel);
        void EditPost(PostModel postModel);
        void DeletePostById(PostModel postModel);
        void GetAllPost(PostModel postModel);
        void GetPostById(PostModel postModel);
    }
}

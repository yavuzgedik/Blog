using Blog.Entity.DBContext;
using Blog.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                var result = db.Post.ToList();
            }

            Post p = new Post();
            p.Title = "HelloWorld";
            p.Content = "İçerik";
            p.PostDate = DateTime.Now;
            
        }
    }
}

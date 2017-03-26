using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Models
{
    public class Writer : Base
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ProfilPhotoUrl { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}

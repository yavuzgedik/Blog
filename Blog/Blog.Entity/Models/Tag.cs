using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Models
{
    public class Tag : Base
    {
        public string Name { get; set; }
        public virtual List<Post> Posts { get; set; }
    }
}

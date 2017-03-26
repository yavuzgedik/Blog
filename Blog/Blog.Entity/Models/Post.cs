using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Models
{
    public class Post : Base
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public int WriterID { get; set; }
        public virtual List<Category> Categories { get; set; }
        public virtual List<Tag> Tags { get; set; }

        public virtual Writer Writer { get; set; }
    }
}

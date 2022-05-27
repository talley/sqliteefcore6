using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteRazorPagesApp.Models
{
    public class Post
    {
        public int PostId { get; set; }

        [Required(ErrorMessage = "Title Required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content Required")]
        public string Content { get; set; }


        [Required(ErrorMessage = "BlogId Required")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}

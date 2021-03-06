using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteRazorPagesApp.Models
{
    public class Blog
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage ="Blog Url required")]
        public string Url { get; set; }

        public List<Post> Posts { get; } = new();
    }
}

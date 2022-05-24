

namespace SqliteRazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BloggingContext _db;
        public List<SqliteRazorPagesApp.Models.Blog> _blogs = new List<SqliteRazorPagesApp.Models.Blog>();
        public IndexModel(ILogger<IndexModel> logger, BloggingContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            _blogs=_db.Blogs.ToList();
        }

        public List<SqliteRazorPagesApp.Models.Blog> Blogs
        {
            get
            {
                return _db.Blogs.ToList();
            }
        }
    }

}
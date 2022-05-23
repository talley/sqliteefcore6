

namespace SqliteRazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BloggingContext _db;
        public List<Blog> _blogs = new List<Blog>();
        public IndexModel(ILogger<IndexModel> logger, BloggingContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            _blogs=_db.Blogs.ToList();
        }

        public List<Blog> Blogs
        {
            get
            {
                return _db.Blogs.ToList();
            }
        }
    }
}
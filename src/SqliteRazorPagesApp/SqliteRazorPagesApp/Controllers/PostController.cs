using Microsoft.AspNetCore.Mvc;

namespace SqliteRazorPagesApp.Controllers
{
    public class PostController : Controller
    {

        private readonly BloggingContext _context;

        public PostController(BloggingContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var posts = await _context.Posts.ToListAsync();
            return View(posts);
        }

        [HttpGet]
        public async Task<IActionResult> Add([FromQuery(Name ="id")] string? id)
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Add(Post model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        return RedirectToAction("Index", new {id= model .PostId});
        //    }
        //    return View(model);
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqliteRazorPagesApp.Controllers
{
    public class BlogController : Controller
    {
        private BloggingContext _db;

        public BlogController(BloggingContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Blog model)
        {
            Exception _ex = new Exception();
            if (ModelState.IsValid)
            {
                try
                {
                    _db.Blogs.Add(model);
                    _db.Entry(model).State = EntityState.Added;
                    var result = await _db.SaveChangesAsync().ConfigureAwait(false);
                    if (result > 0)
                    {
                        return RedirectToPagePermanent("/Index");
                    }
                    else
                    {
                        return View(model);
                    }
                }
                catch (Exception ex)
                {
                    _ex = ex;
                    throw;
                }
            }
            return View(model);
        }

        //[HttpPost]
        //public async Task<IActionResult> Edit(Blog model)
        //{
        //    var blog = await _db.Blogs.SingleOrDefaultAsync(x => x.BlogId == model.BlogId);
        //    if (ModelState.IsValid)
        //    {

        //    }
        //    return View(blog);
        //}

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var blog= await _db.Blogs.SingleOrDefaultAsync(x=>x.BlogId == id).ConfigureAwait(false);
            return View(blog);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesAK.Model;

namespace RazorPagesAK.Pages.Product
{
    public class IndexModel : PageModel
    {
        private readonly ProductDBContext _context;

        public IndexModel(ProductDBContext context)
        {
            _context = context;
        }

        public string Message { get; set; }
        public List<Entities.Product> Products { get; set; }


        public void OnGet()
        {
            Products = _context.Products.ToList();
            Message = $"There are {Products.Count} items in Store";

        }


        [BindProperty]
        public Entities.Product Product { get; set; }

        public IActionResult OnPost()
        {
            _context.Products.Add(Product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

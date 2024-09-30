using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using FEAasp.Models;

namespace FEAasp.Pages
{
    public class SejaModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context;
        public SejaModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Parceiros Parceiros { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Parceiro.Add(Parceiros);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}
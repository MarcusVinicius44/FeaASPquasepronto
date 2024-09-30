using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using FEAasp.Models;

namespace FEAasp.Pages
{
    public class ContatoModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ApplicationDbContext _context;
        public ContatoModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public contato contato { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.contatos.Add(contato);
            _context.SaveChanges();
            return RedirectToPage("./Index", new { message = "Sua mensagem foi enviada para nós, obrigado!" });
        }
    }
}
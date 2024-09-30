using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FEAasp.Pages
{
    public class Cadastro_doacoesModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Cadastro_doacoesModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
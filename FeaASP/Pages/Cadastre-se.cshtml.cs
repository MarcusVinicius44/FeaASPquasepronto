using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FEAasp.Pages
{
    public class CadasModel : PageModel
    {
        private readonly ILogger<CadasModel> _logger;

        public CadasModel(ILogger<CadasModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
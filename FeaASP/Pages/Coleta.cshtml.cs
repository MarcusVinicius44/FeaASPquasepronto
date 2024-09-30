using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FEAasp.Pages
{
    public class ColetaModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public ColetaModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FEAasp.Pages
{
    public class NossospcrModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public NossospcrModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

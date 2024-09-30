using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FEAasp.Pages
{
    public class ForumModel : PageModel
    {
        private readonly ILogger<ForumModel> _logger;

        public ForumModel(ILogger<ForumModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

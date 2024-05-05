using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ensek.Pages
{
    public class MeterReadingModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public MeterReadingModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}

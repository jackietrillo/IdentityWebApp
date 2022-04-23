using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public string DefaultPolicy { get; set; }
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
             
            DefaultPolicy = String.Empty;
        }

        public async Task<ActionResult> OnGetAsync()
        {            
            await Task.Run(() =>
            {
                DefaultPolicy = "Use this page to detail your site's privacy policy";
            });

            return Page();
        }

        public JsonResult OnGetCustomPolicy(int param, DateTime now)
        {    
            return new JsonResult(new { success = false, policy = "Jackie''s custom policy " + now.ToString()});
        }
 
    }
}
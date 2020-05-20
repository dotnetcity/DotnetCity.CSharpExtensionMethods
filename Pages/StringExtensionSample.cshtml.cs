using ExtensionMethods;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCity.CSharpExtensionMethods.Pages
{
    public class StringExtensionSampleModel : PageModel
    {
        public void OnGet()
        {
            string email = "john.smith@hotmail.com";
            if (email.IsValidEmail())
            {
                //valid format
            }
            else
            {
                //invalid format
            }
        }
    }
}
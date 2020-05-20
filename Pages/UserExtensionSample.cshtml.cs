using DotnetCity.CSharpExtensionMethods.Models;
using ExtensionMethods;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCity.CSharpExtensionMethods.Pages
{
    public class UserExtensionSampleModel : PageModel
    {
        public void OnGet()
        {
            var user = new User()
            {
                Email = "john.smith@hotmail.com"
            };
            if (user.IsValidEmail())
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
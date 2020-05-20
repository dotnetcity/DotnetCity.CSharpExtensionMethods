using System;
using ExtensionMethods;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotnetCity.CSharpExtensionMethods.Pages
{
    public class DateTimeExtensionSampleModel : PageModel
    {
        public void OnGet()
        {
            DateTime dtStart = Convert.ToDateTime("2020-01-01");
            DateTime dtEnd = Convert.ToDateTime("2020-01-10");
            DateTime dtNow = DateTime.Now;
            if (dtNow.IsBetween(dtStart, dtEnd))
            {
                //do whatever you need
            }
        }
    }
}
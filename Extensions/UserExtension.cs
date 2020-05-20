using DotnetCity.CSharpExtensionMethods.Models;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class UserExtension
    {
        public static bool IsValidEmail(this User value)
        {
            return Regex.IsMatch(value.Email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }
    }
}

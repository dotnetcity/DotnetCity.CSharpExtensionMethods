using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class StringExtension
    {
        public static bool IsValidEmail(this string email)
        {
            return Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }
    }
}
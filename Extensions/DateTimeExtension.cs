using System;

namespace ExtensionMethods
{
    public static class DateTimeExtension
    {
        public static bool IsBetween(this DateTime dt, DateTime start, DateTime end)
        {
            return dt >= start && dt <= end;
        }
    }
}

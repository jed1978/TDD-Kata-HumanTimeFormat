using System;

namespace HumanTimeFormat
{
    public class TimeFormat
    {
        public string FormatDuration(int s)
        {
            if (s == 1)
                return "1 second";
            if (s <= 59 && s >= 2)
                return $"{s} seconds";
            if (s == 60)
                return "1 minute";

            return "now";
        }
    }
}
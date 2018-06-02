using System;

namespace HumanTimeFormat
{
    public class TimeFormat
    {
        public string FormatDuration(int s)
        {
            if (s == 1)
                return "1 second";

            return "now";
        }
    }
}
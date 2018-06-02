using System;

namespace HumanTimeFormat
{
    public class TimeFormat
    {
        public string FormatDuration(int s)
        {
            if (s <= 0) return "now";

            var format = "";
            var second = s % 60;
            var minute = s / 60;

            if (s <= 59 && s >= 1)
            {
                format = FormatSeconds(s);
            }

            if (minute == 1)
            {
                if (second == 0)
                {
                    format = $"{minute} minute";
                }
                else
                {
                    format = $"{minute} minute and {FormatSeconds(second)}";
                }
            }
            else if (minute <= 59 && minute >= 2)
            {
                if (second == 0)
                {
                    format = $"{minute} minutes";
                }
                else
                {
                    format = $"{minute} minutes and {FormatSeconds(second)}";
                }
            }

            return format;
        }

        private string FormatSeconds(int s)
        {
            var format = $"{s} second";
            return FormatPlural(s, format);
        }

        private static string FormatPlural(int s, string format)
        {
            if (s > 1) format = $"{format}s";
            return format;
        }
    }
}
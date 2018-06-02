using System;

namespace HumanTimeFormat
{
    public class TimeFormat
    {
        public string FormatDuration(int s)
        {
            if (s <= 0) return "now";
            if (s <= 59 && s >= 1)
            {
                return FormatSeconds(s);
            }

            var format = "";
            var second = s % 60;
            var minute = s / 60;
            var hour = minute / 60;
            if (hour >= 1)
            {
                minute = minute % 60;
                second = minute % 60;

                format = $"{hour} hour";
                format = FormatPlural(hour, format);
            }

            if (minute <= 59 && minute >= 1)
            {
                format = $"{minute} minute";
                format = FormatPlural(minute, format);
            }

            if (second > 0)
            {
                format = format + " and " + FormatSeconds(second);
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
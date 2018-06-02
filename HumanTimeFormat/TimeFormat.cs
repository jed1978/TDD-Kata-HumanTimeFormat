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
                return ProcessTimeFormat(s, "second");
            }

            var format = "";
            var second = s % 60;
            var minute = s / 60;
            var hour = minute / 60;
            if (hour >= 1)
            {
                minute = minute % 60;
                if (minute == 0)
                {
                    second = s % (60 * 60);
                }
                else
                {
                    second = minute % 60;
                }

                format = ProcessTimeFormat(hour, "hour");
            }

            if (minute <= 59 && minute >= 1)
            {
                format = ProcessTimeFormat(minute, "minute");
            }

            if (second > 0)
            {
                format = format + " and " + ProcessTimeFormat(second, "second");
            }

            return format;
        }

        private static string ProcessTimeFormat(int timeValue, string timeUnit)
        {
            return FormatPlural(timeValue, $"{timeValue} {timeUnit}");
        }

        private static string FormatPlural(int s, string format)
        {
            if (s > 1) format = $"{format}s";
            return format;
        }
    }
}
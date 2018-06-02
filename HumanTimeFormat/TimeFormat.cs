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
           
            var second = s % 60;
            var minute = s / 60;
            var hour = minute / 60;
            var day = hour / 24;
            var year = day / 365;

            return Format(year, day, hour, minute, second);
        }

        private static string Format(int year, int day, int hour, int minute, int second)
        {
            string format = "";
            if (year > 0)
            {
                day = day % 365;
                format += ProcessTimeFormat(year, "year");
            }

            if (day <= 364 && day >= 1)
            {
                hour = hour % 24;
                if (format != "") format += ", ";
                format += ProcessTimeFormat(day, "day");
            }

            if (hour <= 23 && hour >= 1)
            {
                minute = minute % 60;
                if (format != "") format += ", ";
                format += ProcessTimeFormat(hour, "hour");
            }

            if (minute <= 59 && minute >= 1)
            {
                if (format != "") format += ", ";
                format += ProcessTimeFormat(minute, "minute");
            }

            if (second > 0)
            {
                format += " and " + ProcessTimeFormat(second, "second");
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
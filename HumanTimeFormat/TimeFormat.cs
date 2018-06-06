using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;

namespace HumanTimeFormat
{
    public class TimeFormat
    {
        public string FormatDuration(int s)
        {
            if (s == 0) return "now";

            var formattedTime = "";
            var formattedTimeUnit = GetFormattedTimeWithUnit(s);
            var formattedWithPunctuation = ProcessPunctuationMark(formattedTimeUnit);

            foreach (var t in formattedWithPunctuation)
            {
                formattedTime += t;
            }

            return formattedTime;
        }

        private static LinkedList<string> ProcessPunctuationMark(List<string> formattedTimeUnit)
        {
            var timeFormat = new LinkedList<string>();

            for (int i = 0; i < formattedTimeUnit.Count; i++)
            {
                if (i > 1) timeFormat.AddFirst(", ");
                if (i == 1) timeFormat.AddFirst(" and ");
                timeFormat.AddFirst(formattedTimeUnit[i]);
            }

            return timeFormat;
        }

        private static List<string> GetFormattedTimeWithUnit(int s)
        {
            var times = ConvertDuration(s);
            var timeUnit = new[] {"second", "minute", "hour", "day", "year"};
            var formattedTimeUnit = new List<string>();

            for (int i = 0; i < times.Length; i++)
            {
                var time = GetFormattedTime(times[i], timeUnit[i]);
                if (time != "") formattedTimeUnit.Add(GetFormattedTime(times[i], timeUnit[i]));
            }

            return formattedTimeUnit;
        }

        private static int[] ConvertDuration(int s)
        {
            var sec = s % 60;
            var min = s / 60;
            var hour = min / 60;
            if (hour > 0) min = min % 60;
            var day = hour / 24;
            if (day > 0) hour = hour % 24;
            var year = day / 365;
            if (year > 0) day = day % 365;
            var convertDuration = new[] {sec, min, hour, day, year};
            return convertDuration;
        }

        private static string GetFormattedTime(int time, string timeUnit)
        {
            string formattedSec = "";
            if (time <= 59 && time >= 1)
            {
                formattedSec = $"{time} {timeUnit}";
                if (time > 1) formattedSec = $"{formattedSec}s";
            }

            return formattedSec;
        }
    }
}
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
            if (s == 0)
            {
                return "now";
            }

            var formattedTime = "";
            var formattedSec = "";
            var formattedMin = "";
            var formattedHour = "";
            string formattedDay = "";

            var sec = s % 60;
            var min = s / 60;
            var hour = min / 60;
            if (hour > 0) min = min % 60;
            var day = hour / 24;
            if (day > 0) hour = hour % 24;

            var formattedTimeUnit = new List<string>();
            formattedSec = GetFormattedTime(sec, "second");
            formattedMin = GetFormattedTime(min, "minute");
            formattedHour = GetFormattedTime(hour, "hour");
            formattedDay = GetFormattedTime(day, "day");
            if (formattedSec != "") formattedTimeUnit.Add(formattedSec);
            if (formattedMin != "") formattedTimeUnit.Add(formattedMin);
            if (formattedHour != "") formattedTimeUnit.Add(formattedHour);
            if (formattedDay != "") formattedTimeUnit.Add(formattedDay);
            

            var timeFormat = new LinkedList<string>();
             
            for (int i = 0; i < formattedTimeUnit.Count; i++)
            {
                if (i > 1) timeFormat.AddFirst(", ");
                if (i == 1) timeFormat.AddFirst(" and ");
                timeFormat.AddFirst(formattedTimeUnit[i]);
            }

            foreach (var t in timeFormat)
            {
                formattedTime += t;
            }

            return formattedTime;
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
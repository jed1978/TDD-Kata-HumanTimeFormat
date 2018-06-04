﻿namespace HumanTimeFormat
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
            var sec = s % 60;
            var min = s / 60;
            var hour = min / 60;
            if (hour > 0) min = min % 60;

            formattedSec = GetFormattedTime(sec, "second");
            formattedMin = GetFormattedTime(min, "minute");
            formattedHour = GetFormattedTime(hour, "hour");
            
            if (hour > 0)
            {
                formattedTime = formattedHour;
            }
            
            if (min > 0)
            {
                if (hour > 0) formattedTime += ", ";
                formattedTime += formattedMin;

                if (sec > 0)
                {
                    formattedTime += " and " + formattedSec;
                }
            }
            else
            {
                if (sec > 0)
                    if (hour > 0) formattedTime += " and ";
                formattedTime += formattedSec;
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
using System;

namespace HumanTimeFormat
{
    public class TimeFormat
    {
        public string FormatDuration(int s)
        {
            if (s <= 0) return "now";

            var formatDuration = "";

            if (s <= 59 && s >= 1)
            {
                if (s == 1)
                {
                    formatDuration = "1 second";
                }
                else
                {
                    formatDuration = $"{s} seconds";
                }
            }

            if (s <= 360 && s >= 60)
            {
                if (s == 60)
                    formatDuration = "1 minute";
                else
                {
                    var second = s % 60;
                    var minute = s / 60;
                    formatDuration = $"{minute} minute and {second} second";
                }
            }

            return formatDuration;
        }
    }
}
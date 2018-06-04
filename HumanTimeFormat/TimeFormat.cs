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
            var sec = s % 60;
            var min = s / 60;

            formattedSec = GetFormattedTime(sec, "second");
            formattedMin = GetFormattedTime(min, "minute");

            if (min > 0)
            {
                formattedTime = formattedMin;
                if (sec > 0)
                {
                    formattedTime += " and " + formattedSec;
                }
            }
            else
            {
                formattedTime = formattedSec;
            }

            return formattedTime;
        }

        private static string GetFormattedTime(int time, string timeUnit)
        {
            string formattedSec="";
            if (time <= 59 && time >= 1)
            {
                formattedSec = $"{time} {timeUnit}";
                if (time > 1) formattedSec = $"{formattedSec}s";
            }

            return formattedSec;
        }
    }
}
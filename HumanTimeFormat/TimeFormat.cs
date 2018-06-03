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

            if (sec <= 59 && sec >= 1)
            {
                formattedSec = $"{sec} second";
                if (sec > 1) formattedSec = $"{formattedSec}s";
            }

            if (min <= 59 && min >= 1)
            {
                formattedMin = $"{min} minute";
            }


            formattedTime = formattedMin + formattedSec;
            return formattedTime;
        }
    }
}
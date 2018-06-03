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

            var formattedTime = $"{s} second";
            if (s > 1) formattedTime = $"{formattedTime}s";

            return formattedTime;
        }
    }
}
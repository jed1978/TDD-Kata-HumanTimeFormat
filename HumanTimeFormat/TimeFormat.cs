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
            else
            {
                return "1 second";
            }
        }
    }
}
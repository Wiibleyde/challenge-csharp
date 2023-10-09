namespace CSharpDiscovery.Quest02
{
    public class FromStringToDateTime_Exercice
    {
        public static DateTime FromStringToDateTime(string dateStr)
        {
            if (dateStr.Contains('h')) {
                dateStr = dateStr.Replace('h', ':');
            }
            return DateTime.Parse(dateStr);
        }
    }
}
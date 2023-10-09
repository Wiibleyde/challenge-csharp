using System;

namespace CSharpDiscovery.Quest02
{
    public class TodayAtMidnight_Exercice
    {
        public static DateTime TodayAtMidnight()
        {
            DateTime now = DateTime.Today;
            DateTime midnight = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0);
            return midnight;            
        }
    }
}
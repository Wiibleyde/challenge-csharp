using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            return currentColor switch
            {
                TrafficLightColor.Red => TrafficLightColor.Green,
                TrafficLightColor.Orange => TrafficLightColor.Red,
                TrafficLightColor.Green => TrafficLightColor.Orange,
                _ => TrafficLightColor.None
            };
        }
    }
}
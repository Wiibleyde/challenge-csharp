namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Name { get; set; }
        public static string GoogleMapsUrlTemplate { get; }= "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest(string name = "Bordeaux Ynov Campus", double latitude = 44.854186, double longitude = -0.5663056)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
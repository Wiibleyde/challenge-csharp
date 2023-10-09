namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Name { get; set; }
        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/" {
            get {
                return GoogleMapsUrlTemplate;
            }
            set {
                GoogleMapsUrlTemplate = value;
            }
        }
    }
}
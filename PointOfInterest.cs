namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Name { get; set; }
        public static string GoogleMapsUrlTemplate { get; }= "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }

        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        public string GetGoogleMapsUrl()
        {
            return string.Format(GoogleMapsUrlTemplate, Name.Replace(" ", "+"), Latitude, Longitude);
        }

        public override string ToString()
        {
            return $"{Name} (Lat={Latitude}, Long={Longitude})";
        }

        private double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double radiusOfEarthKm = 6371.0; 

            double dLat = DegreeToRadian(lat2 - lat1);
            double dLon = DegreeToRadian(lon2 - lon1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(DegreeToRadian(lat1)) * Math.Cos(DegreeToRadian(lat2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return radiusOfEarthKm * c;
        }
        
        private double DegreeToRadian(double degree)
        {
            return degree * Math.PI / 180.0;
        }

        public int GetDistance(PointOfInterest other)
        {
            return (int)Math.Round(CalculateDistance(Latitude, Longitude, other.Latitude, other.Longitude));
        }

        public static int GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            return (int)Math.Round(p1.CalculateDistance(p1.Latitude, p1.Longitude, p2.Latitude, p2.Longitude));
        }
    }
}
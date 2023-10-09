namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest
    {
        public int BuildYear { get; set; }

        public HistoricalMonument()
        {
        }

        public HistoricalMonument(double latitude, double longitude, string name, int buildYear) : base(name, latitude, longitude)
        {
            BuildYear = buildYear;
        }

        public override string ToString()
        {
            return $"{Name} is a historical monument built in {BuildYear}";
        }
    }
}

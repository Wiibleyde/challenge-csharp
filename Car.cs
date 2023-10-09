namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model { get; set; }

        public Car()
        {
            Model = "Unknown";
        }

        public Car(string Brand, string Color, string Model, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed)
        {
            this.Model = Model;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Color})";
        }
    }
}
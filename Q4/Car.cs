namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model { get; set; }

        public Car()
        {
            Model = "Unknown";
        }

        public Car(string Model, string Brand, string Color, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed)
        {
            this.Model = Model;
        }

        public override string ToString()
        {
            return $"{Color} {Brand} {Model}";
        }

        public override void Accelerate(int Speed)
        {
            CurrentSpeed += Speed;
            if (CurrentSpeed > 180)
            {
                CurrentSpeed = 180;
            }
            if (CurrentSpeed < 0) 
            {
                CurrentSpeed = 0;
            }
        }

        public override void Brake(int BrakePower)
        {
            CurrentSpeed -= BrakePower;
            if (CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
        }
    }
}
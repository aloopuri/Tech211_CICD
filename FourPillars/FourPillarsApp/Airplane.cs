namespace FourPillarsApp
{
    public class Airplane : Vehicle
    {
        private string _airline;
        public int Altitude { get; set; }

        public Airplane(int capacity) : base(capacity)
        {
            _airline = "";
        }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline;
        }

        //<1000000
        public void Ascend(int distance)
        {
            Altitude += distance;
        }
        
        public void Descend(int distance)
        {
            if (Altitude - distance < 0) throw new ArgumentException("Can't go below 0 metres");
            Altitude -= distance;
        }

        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} metres";
        }
        
        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {Altitude} metres";
        }

        //rewrite base method
        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} altitude: {Altitude}";
        }
    }
}

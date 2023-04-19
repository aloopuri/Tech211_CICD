namespace FourPillarsApp
{
    public class Hunter : Person, IShootable
    {
        //private string _camera = "";
        public IShootable Shooter { get; set; }

        //public Hunter(string fName, string lName, string camera = "") : base(fName, lName)
        //{
        //    _camera = camera;
        //}

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            this.Shooter = shooter;
        }

        public string Shoot()
        {
            //return $"{GetFullName()} takes a photo with their {Shooter}";
            return Shooter.Shoot();
        }

        public override string ToString()
        {
            return $"{base.ToString()}, _camera: {Shooter}";
        }

        public override string GetFullName()
        {
            return $"Hunter {base.GetFullName()}";
        }
    }
}

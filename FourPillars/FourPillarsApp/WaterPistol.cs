namespace FourPillarsApp
{
    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {
        }

        public override string Shoot()
        {
            return $"Splash!! {base.Shoot()}";
        }
    }
}

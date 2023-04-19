namespace FourPillarsApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"Taking a photo with a {_brand} camera.";
        }
    }
}

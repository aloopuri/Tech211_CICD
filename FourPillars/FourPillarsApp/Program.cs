namespace FourPillarsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*

            //instantiation
            Person andrew = new Person("Andrew", "Ma");

            // same thing as above
            //Person andrew = new ("Andrew", "Ma");
            andrew.Age = 22;
            Console.WriteLine(andrew.GetFullName());

            var talal = new Person("Talal", "Hassan", 22);
            Console.WriteLine(talal.GetFullName("Mr"));

            //object initialisers
            var patrick = new Person("Patrick", "Ardagh") { Age = 24, Height = 300 };
            var array = new int[] { 1, 2, 3 };
            var list = new List<int>() { 1, 4, 7 };

            Park park = new Park() { Roundabouts = 1, Swings = 10, ParkManager = new Person("David", "Davidson") };

            //don't have to provide a new object for a struct like below
            //Point3D point; // This is not null, contains all of its variables with default values/null
            //Person aPerson; // This is equal to null, contains nothing

            Point3D point = new Point3D(1, 2);
            Point3D theresAlwaysABlankConstructor = new Point3D();
            Point3D empty;

            //point is passed by value, copied. patrick is passed by refernce.
            DoThis(point, patrick);

            Hunter danielle = new Hunter("Danielle", "Massey", "Kodak");
            Console.WriteLine(danielle.Shoot());
            Console.WriteLine(danielle.GetFullName("Ms."));
            Console.WriteLine(danielle.ToString());

            Hunter idris = new("Idris", "Ahmed", "Canon");

            Console.WriteLine($"idris Equals danielle? {idris.Equals(danielle)}");
            Console.WriteLine($"idris HashCode: {idris.GetHashCode()}");
            Console.WriteLine($"idris Type: {idris.GetType()}");
            Console.WriteLine($"idris ToString: {idris}");

            Console.WriteLine(idris.GetFullName());

            */

            // Thrusday

            var myDog = new Dog();
            var myCat = new Cat();
            var myBird = new Bird();

            Console.WriteLine(myDog.Speak());
            Console.WriteLine(myCat.Speak());
            Console.WriteLine(myBird.Speak());

            Console.WriteLine("\nPolymorphism demo: \n");

            List<Animal> animals = new List<Animal>() { myDog, myCat, myBird };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Speak());
            }

            Console.WriteLine();

            /*
            //another polymorphism example
            Animal myAnimal;

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "dog":
                    myAnimal = new Dog();
                    break;
                case "cat":
                    myAnimal = new Cat();
                    break;
                case "bird":
                    myAnimal = new Bird();
                    break;
                default :
                    myAnimal = null;
                    break;
            }

            if (myAnimal is not null) Console.WriteLine(myAnimal.Speak());
            */

            /* 
            // changed hunter class to use IShootable in parameter for polymorphism shootout lab

            Console.WriteLine();

            List<Object> gameObjects = new List<Object>()
            {
                new Airplane(15),
                new Dog(),
                new Cat(),
                new Park(),
                new Person("Jacob", "Banyard"),
                new Hunter("Majid", "Laklouk", "Nikon"),
                new Vehicle()
            };

            foreach (var obj in gameObjects)
            {
                //Console.WriteLine($"{obj}'s hashcode is {obj.GetHashCode()}");
                SpartaWrite(obj);
                if (obj is Animal)
                {
                    Animal a = (Animal)obj;
                    //Console.WriteLine(a.Speak());
                    SpartaWrite(a.Speak());
                }
            }

            Console.WriteLine();

            List<IMoveable> moveables = new()
            {
                new Person("Jacob", "Banyard"),
                new Hunter("Majid", "Laklouk", "Nikon"),
                new Vehicle(),
                new Airplane(25)
            };

            foreach (var m in moveables)
            {
                SpartaWrite(m.Move(2));
            }

            */

            Console.WriteLine("Polymorphism Shootout Lab");

            LaserGun pew = new LaserGun("pewpew");
            Camera cam = new Camera("Samsung");
            List<IShootable> wep = new List<IShootable>() {
                new LaserGun("space"),
                new LaserGun("laser"),
                new WaterPistol("nerf"),
                new WaterPistol("water"),
                new Hunter("John", "Doe", pew),
                new Hunter("Smith", "Smith", cam),
                new Camera("Nikon"),
                new Camera("Sony")
            };

            foreach (var m in wep)
            {
                Console.WriteLine(m.Shoot());
            }
        }

        public static void DoThis(Point3D p, Person person)
        {
            p.x = 100;
            person.Age = 99;
        }

        public static void SpartaWrite(Object obj)
        {
            Console.WriteLine($"Sparta says: {obj}");
        }
    }
}
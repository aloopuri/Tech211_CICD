using FourPillarsApp;

namespace FourPillarsTests
{
    public class ClassStructsTests
    {
        //Person aPerson;

        //[SetUp]
        //public void CreatePerson()
        //{
        //    aPerson = new Person("John", "Smith");
        //}

        [TestCase("John", "Smith", 18, 0)]
        [TestCase("John", "Smith", 22, 99)]
        public void GivenValidAge_SetAgeTo99(string fName, string lName, int age, int newAge)
        {
            Person aPerson = new Person(fName, lName, age);
            aPerson.Age = newAge;
            Assert.That(aPerson.Age, Is.EqualTo(newAge));
        }

        [TestCase("John", "Smith", -1)]
        [TestCase("John", "Smith", -20)]
        public void GivenInValidAge_AgeIsUnchanged(string fName, string lName, int invalidAge)
        {
            Person aPerson = new Person("John", "Smith");
            aPerson.Age = invalidAge;
            Assert.That(aPerson.Age, Is.EqualTo(18));
        }

        [TestCase("John", "Smith")]
        [TestCase("", "")]
        public void GetFullName_ContainsCorrectFirstNameAndLastName(string fName, string lName)
        {
            Person aPerson = new Person(fName, lName);
            string result = aPerson.GetFullName();
            string[] names = result.Split(' ');

            Assert.That(names[0], Is.EqualTo(fName));
            Assert.That(names[1], Is.EqualTo(lName));
        }

        [TestCase("John", "Smith", "John Smith")]
        [TestCase("", "", " ")]
        public void GetFullName_ReturnsCorrectString(string fName, string lName, string expected)
        {
            Person aPerson = new Person(fName, lName);
            string result = aPerson.GetFullName();

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("John", "Smith", "Mr", "Mr John Smith")]
        public void GetFullNameWithTitleParam_ReturnsCorrectString(string fName, string lName, string title, string expected)
        {
            Person aPerson = new Person(fName, lName);
            string result = aPerson.GetFullName(title);

            Assert.That(result, Is.EqualTo(expected));
        }


    }
}
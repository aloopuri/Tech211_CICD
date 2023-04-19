using FourPillarsApp;

namespace FourPillarsTests
{
    public class VehicleTests
    {
        [Test]
        public void Vehicle_ConstructsSuccesfully()
        {
            Vehicle v = new Vehicle();
            Assert.Pass();
        }

        [Test]
        public void Vehicle_ConstructsSuccesfully_GivenCapacitySpeed()
        {
            Vehicle v = new Vehicle(5, 40);
            Assert.Pass();
        }

        [Test]
        public void Vehicle_ConstructswWithDefaultSpeed()
        {
            Vehicle v = new Vehicle();
            Assert.That(v.Speed, Is.EqualTo(10));
        }

        [Test]
        public void Vehicle_ConstructswWithCorrectSpeed()
        {
            Vehicle v = new Vehicle(5, 40);
            Assert.That(v.Speed, Is.EqualTo(40));
        }



        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);
            Assert.That(v.Position, Is.EqualTo(20));
            Assert.That(result, Is.EqualTo("Moving along 2 times"));

            //Assert.AreEqual(20, v.Position);
            //Assert.AreEqual("Moving along 2 times", result);
        }

        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();

            Assert.That(v.Position, Is.EqualTo(40));
            Assert.That(result, Is.EqualTo("Moving along"));
            //Assert.AreEqual(40, v.Position);
            //Assert.AreEqual("Moving along", result);
        }

        [TestCase(0,0)]
        [TestCase(2,2)]
        [TestCase(5,5)]
        public void WhenNumberOfPassengersBetween0AndCapacity_SetValidNumberOfPassengers(int numPassengers, int expected)
        {
            Vehicle v = new Vehicle(5, 40);
            v.NumPassengers = numPassengers;
            var result = v.NumPassengers;

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(6, 0)]
        [TestCase(10, 0)]
        [TestCase(-1, 0)]
        [TestCase(-10, 0)]
        public void GivenInvalidNumberOfPassengers_NumPassengersStaysTheSame(int numPassengers, int expected)
        {
            Vehicle v = new Vehicle(5, 40);
            v.NumPassengers = numPassengers;
            var result = v.NumPassengers;

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}

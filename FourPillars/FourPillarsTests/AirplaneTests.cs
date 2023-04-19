using FourPillarsApp;

namespace FourPillarsTests
{
    public class AirplaneTests
    {
        [TestCase(0, 1000, 1000)]
        [TestCase(200, 500, 700)]
        public void Ascend_UpdatesAltitudeCorrectly(int initialAlt, int addAlt, int expected)
        {
            Airplane plane = new Airplane(200) { Altitude = initialAlt};

            plane.Ascend(addAlt);

            Assert.That(plane.Altitude, Is.EqualTo(expected));
        }

        [TestCase(500, 500, 0)]
        [TestCase(1000, 500, 500)]
        public void Descend_UpdatesAltitudeCorrectly(int initialAlt, int subtractAlt, int expected)
        {
            Airplane plane = new Airplane(200) { Altitude = initialAlt};

            plane.Descend(subtractAlt);

            Assert.That(plane.Altitude, Is.EqualTo(expected));
        }

        [Test]
        public void WhenDescendingBelowZero_Descend_ThrowArgumentException()
        {
            Airplane plane = new Airplane(200) { Altitude = 100 };

            Assert.That(() => plane.Descend(500), Throws.TypeOf<ArgumentException>())
        }

        [Test]
        public void Move_ReturnsCorrectMessage()
        {
            Airplane plane = new Airplane(200) { Altitude = 100 };

            Assert.That(plane.Move(), Is.EqualTo("Moving along at an altitude of 100 metres"));
        }

        [Test]
        public void MoveNTimes_ReturnsCorrectMessage()
        {
            Airplane plane = new Airplane(200) { Altitude = 100 };

            Assert.That(plane.Move(3), Is.EqualTo("Moving along 3 times at an altitude of 100 metres"))
        }

        [Test]
        public void ToString_ReturnsCorrectMessage()
        {
            Airplane plane = new Airplane(200, 100, "JetsRUs") { NumPassengers = 150, Altitude = 100};

            Assert.That(plane.ToString(), Is.EqualTo("Thank you for flying JetsRUs: FourPillarsApp.Airplane " +
                "capacity: 200 passengers: 150 speed: 100 position: 0 altitude: 100"));
        }

    }
}

using Moq;
using NUnit.Framework;

namespace strategy.tests
{
    [TestFixture]
    public class WalkTests
    {
        private readonly Viking viking;
        private readonly Walk walk;

        public WalkTests()
        {
            viking = new Viking();
            walk = new Walk();
        }

        [Test]
        public void ShouldIncreasePositionBy1()
        {
            walk.Move(viking);
            Assert.AreEqual(1, viking.Position);
        }
    }
}
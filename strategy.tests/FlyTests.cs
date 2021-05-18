using Moq;
using NUnit.Framework;

namespace strategy.tests
{
    [TestFixture]
    public class FlyTests
    {
        private readonly Viking viking;
        private readonly Fly fly;

        public FlyTests()
        {
            viking = new Viking();
            fly = new Fly();
        }

        [Test]
        public void ShouldIncreasePositionBy10()
        {
            fly.Move(viking);
            Assert.AreEqual(10, viking.Position);
        }
    }
}
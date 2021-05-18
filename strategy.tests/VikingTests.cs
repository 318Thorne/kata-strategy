using Moq;
using NUnit.Framework;

namespace strategy.tests
{
    [TestFixture]
    public class VikingTests
    {
        private readonly Mock<IMoveBehaviour> mockMoveBehaviour;
        private readonly Viking viking;

        public VikingTests()
        {
            mockMoveBehaviour = new Mock<IMoveBehaviour>();
            viking = new Viking();
        }

        [SetUp]
        public void Setup()
        {
            mockMoveBehaviour.Reset();
            viking.MoveBehaviour = mockMoveBehaviour.Object;
        }

        [Test]
        public void ShouldCallMoveBehaviourMoveonMove()
        {
            viking.Move();
            mockMoveBehaviour.Verify(m => m.Move(It.IsAny<Viking>()));
        }
    }
}
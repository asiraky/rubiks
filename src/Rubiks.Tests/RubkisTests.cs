using System.Linq;
using NUnit.Framework;

namespace Rubiks.Tests
{
    [TestFixture]
    public class RubkisTests
    {
        [Test]
        public void VerifyTheCorrectNumberOfUniquePositionsInstances()
        {
            //Arrange
            var cube = new Cube();
            
            //Act
            var uniqueInstances = cube.Faces.SelectMany(face => face.Positions).Distinct(PositionInstanceEqualityComparer.Instance).Count();
            
            //Assert
            Assert.AreEqual(20, uniqueInstances, "There should be 20 unique positions shared across the rubkic cube faces");
        }
    }
}

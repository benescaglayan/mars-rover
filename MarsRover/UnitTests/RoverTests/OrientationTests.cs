using Core.Enums;
using Core.Models;
using Xunit;

namespace UnitTests.RoverTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldHeadWest_WhenTurnedLeft_GivenHeadedNorth()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.N };

            systemUnderTest.TurnLeft();

            Assert.Equal(Orientation.W, systemUnderTest.Orientation);
        }
        
        [Fact]
        public void ShouldHeadEast_WhenTurnedRight_GivenHeadedNorth()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.N };

            systemUnderTest.TurnRight();

            Assert.Equal(Orientation.E, systemUnderTest.Orientation);
        }
        
        [Fact]
        public void ShouldHeadNorth_WhenTurnedLeft_GivenHeadedEast()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.E };

            systemUnderTest.TurnLeft();

            Assert.Equal(Orientation.N, systemUnderTest.Orientation);
        }
        
        [Fact]
        public void ShouldHeadSouth_WhenTurnedRight_GivenHeadedEast()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.E };

            systemUnderTest.TurnRight();

            Assert.Equal(Orientation.S, systemUnderTest.Orientation);
        }
        
        [Fact]
        public void ShouldHeadEast_WhenTurnedLeft_GivenHeadedSouth()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.S };

            systemUnderTest.TurnLeft();

            Assert.Equal(Orientation.E, systemUnderTest.Orientation);
        }
        
        [Fact]
        public void ShouldHeadWest_WhenTurnedRight_GivenHeadedSouth()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.S };

            systemUnderTest.TurnRight();

            Assert.Equal(Orientation.W, systemUnderTest.Orientation);
        }
        
        [Fact]
        public void ShouldHeadSouth_WhenTurnedLeft_GivenHeadedWest()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.W };

            systemUnderTest.TurnLeft();

            Assert.Equal(Orientation.S, systemUnderTest.Orientation);
        }
        
        [Fact]
        public void ShouldHeadNorth_WhenTurnedRight_GivenHeadedWest()
        {
            var systemUnderTest = new Rover { Orientation = Orientation.W };

            systemUnderTest.TurnRight();

            Assert.Equal(Orientation.N, systemUnderTest.Orientation);
        }
    }
}
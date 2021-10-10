using Core.Enums;
using Core.Exceptions;
using Core.Models;
using Xunit;

namespace UnitTests.RoverTests
{
    public class MoveTests
    {
        [Fact]
        public void ShouldThrowInvalidCommandException_WhenMoved_GivenHeadedWestAtLeftEdge()
        {
            var xCoord = 0;
            var yCoord = 3;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.W,
                PlateauUppRightLoc = new Location { XCoord = 6, YCoord = 6 }
            };

            Assert.Throws<InvalidCommandException>(() => systemUnderTest.Move());
        }
        
        [Fact]
        public void ShouldMoveWest_WhenMoved_GivenHeadedWest()
        {
            var xCoord = 3;
            var yCoord = 3;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.W,
                PlateauUppRightLoc = new Location { XCoord = 6, YCoord = 6 }
            };

            systemUnderTest.Move();

            Assert.Equal(xCoord - 1, systemUnderTest.Location.XCoord);
        }
        
        [Fact]
        public void ShouldThrowInvalidCommandException_WhenMoved_GivenHeadedNorthAtUpperEdge()
        {
            var xCoord = 6;
            var yCoord = 6;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.N,
                PlateauUppRightLoc = new Location { XCoord = xCoord, YCoord = yCoord }
            };

            Assert.Throws<InvalidCommandException>(() => systemUnderTest.Move());
        }
        
        [Fact]
        public void ShouldMoveNorth_WhenMoved_GivenHeadedNorth()
        {
            var xCoord = 2;
            var yCoord = 3;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.N,
                PlateauUppRightLoc = new Location { XCoord = 6, YCoord = 6 }
            };

            systemUnderTest.Move();

            Assert.Equal(yCoord + 1, systemUnderTest.Location.YCoord);
        }
        
        [Fact]
        public void ShouldThrowInvalidCommandException_WhenMoved_GivenHeadedEastAtRightEdge()
        {
            var xCoord = 6;
            var yCoord = 6;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.E,
                PlateauUppRightLoc = new Location { XCoord = xCoord, YCoord = yCoord }
            };

            Assert.Throws<InvalidCommandException>(() => systemUnderTest.Move());
        }
        
        [Fact]
        public void ShouldMoveEast_WhenMoved_GivenHeadedEast()
        {
            var xCoord = 2;
            var yCoord = 3;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.E,
                PlateauUppRightLoc = new Location { XCoord = 6, YCoord = 6 }
            };

            systemUnderTest.Move();

            Assert.Equal(xCoord + 1, systemUnderTest.Location.XCoord);
        }
        
        [Fact]
        public void ShouldThrowInvalidCommandException_WhenMoved_GivenHeadedEastAtLowerEdge()
        {
            var xCoord = 4;
            var yCoord = 0;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.S,
                PlateauUppRightLoc = new Location { XCoord = 6, YCoord = 6 }
            };

            Assert.Throws<InvalidCommandException>(() => systemUnderTest.Move());
        }
        
        [Fact]
        public void ShouldMoveSouth_WhenMoved_GivenHeadedSouth()
        {
            var xCoord = 2;
            var yCoord = 3;
            
            var systemUnderTest = new Rover
            {
                Location = new Location { XCoord = xCoord, YCoord = yCoord },
                Orientation = Orientation.S,
                PlateauUppRightLoc = new Location { XCoord = 6, YCoord = 6 }
            };

            systemUnderTest.Move();

            Assert.Equal(yCoord - 1, systemUnderTest.Location.YCoord);
        }
    }
}
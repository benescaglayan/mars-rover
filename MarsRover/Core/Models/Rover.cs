using System;
using Core.Enums;
using Core.Exceptions;

namespace Core.Models
{
    public class Rover
    {
        public Location Location { get; set; }
        
        public Orientation Orientation { get; set; }
        
        public Location PlateauUppRightLoc { get; set; }

        public void TurnRight()
        {
            switch (Orientation)
            {
                case Orientation.N:
                    Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    Orientation = Orientation.N;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Orientation)
            {
                case Orientation.N:
                    Orientation = Orientation.W;
                    break;
                case Orientation.W:
                    Orientation = Orientation.S;
                    break;
                case Orientation.S:
                    Orientation = Orientation.E;
                    break;
                case Orientation.E:
                    Orientation = Orientation.N;
                    break;
            }
        }

        public void Move()
        {
            switch (Orientation)
            {
                case Orientation.N:
                    MoveNorth();
                    break;
                case Orientation.W:
                    MoveWest();
                    break;
                case Orientation.S:
                    MoveSouth();
                    break;
                case Orientation.E:
                    MoveEast();
                    break;
            }
        }

        private void MoveNorth()
        {
            if (Location.YCoord == PlateauUppRightLoc.YCoord)
            {
                throw new InvalidCommandException();
            }

            Location.YCoord++;
        }
        
        private void MoveEast()
        {
            if (Location.XCoord == PlateauUppRightLoc.XCoord)
            {
                throw new InvalidCommandException();
            }

            Location.XCoord++;
        }
        
        private void MoveSouth()
        {
            if (Location.YCoord == 0)
            {
                throw new InvalidCommandException();
            }

            Location.YCoord--;
        }
        
        private void MoveWest()
        {
            if (Location.XCoord == 0)
            {
                throw new InvalidCommandException();
            }

            Location.XCoord--;
        }
    }
}
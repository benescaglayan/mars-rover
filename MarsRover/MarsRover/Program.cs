using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using Core.Enums;
using Core.Exceptions;
using Core.Models;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Batuhan Caglayan\Rider Projects\mars-rover\MarsRover\MarsRover\input.txt");
            string[] upperRightCords = lines[0].Split(" ");
            int upperRightX = Int32.Parse(upperRightCords[0]);
            int upperRightY = Int32.Parse(upperRightCords[1]);

            var rovers = new List<Rover>();
            for (int i = 1; i < lines.Length; i += 2)
            {
                string[] roverPosition = lines[i].Split(" ");
                string roverPath = lines[i + 1];
                
                int roverX = Int32.Parse(roverPosition[0]);
                int roverY = Int32.Parse(roverPosition[1]);
                Orientation roverOrientation = (Orientation) Enum.Parse(typeof(Orientation), roverPosition[2]);

                var rover = new Rover
                {
                    Location = new Location { XCoord = roverX, YCoord = roverY } , 
                    Orientation = roverOrientation,
                    PlateauUppRightLoc = new Location { XCoord = upperRightX, YCoord = upperRightY}
                };
                rovers.Add(rover);

                MoveRover(rover, roverPath);
                Console.WriteLine($"{rover.Location.XCoord} {rover.Location.YCoord} {rover.Orientation.ToString()}");
            }
        }

        private static void MoveRover(Rover rover, string roverPath)
        {
            foreach (var command in roverPath)
            {
                try
                {
                    ProcessCommand(rover, command);
                }
                catch (InvalidCommandException e)
                {
                    //TODO: should either alert or somehow log here, unable to do so for now not to interfere with output stream.
                }
            }
        }

        private static void ProcessCommand(Rover rover, char command)
        {
            switch (command) 
            {
                case 'R':
                    rover.TurnRight();
                    break;
                case 'L':
                    rover.TurnLeft();
                    break;
                case 'M':
                    rover.Move();
                    break;
            }
        }
    }
}
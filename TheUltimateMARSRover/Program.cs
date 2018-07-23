using System;
using TheUltimateMARSRover.Contracts;

namespace TheUltimateMARSRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string moves = "";

            try
            {
                UltimateRover Rover = FileParser.Parsefile(out moves);
                Rover.ExecuteCommand(moves);

                Console.Write($"Final Position - {Rover.CurrPosition.X},{Rover.CurrPosition.Y} Orientation - {Rover.Orientation}");
                Console.Read();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                Console.Read();
            }
        }
    }
}

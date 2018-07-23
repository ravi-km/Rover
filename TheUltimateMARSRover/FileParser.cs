using System;
using System.Configuration;
using System.IO;
using TheUltimateMARSRover.Contracts;

namespace TheUltimateMARSRover
{
    public static class FileParser
    {
        public static UltimateRover Parsefile(out string moves)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["filePath"];
                var readText = File.ReadAllLines(path);

                UltimateRover Rover = new UltimateRover()
                {
                    CurrPosition = new Position(),
                    Landscape = new Position(),
                    Orientation = Orientation.Undefined
                };

                string landScape = readText[0].Trim();
                int coDigits = landScape.Length / 2;

                Rover.Landscape.X = Convert.ToInt32(landScape.Substring(0, coDigits));
                Rover.Landscape.Y = Convert.ToInt32(landScape.Substring(coDigits));

                string currPos = readText[1].Trim();
                string[] currPosSplit = currPos.Split(' ');

                Rover.CurrPosition.X = Convert.ToInt32(currPosSplit[0].Substring(0, coDigits));
                Rover.CurrPosition.Y = Convert.ToInt32(currPosSplit[0].Substring(coDigits));

                Rover.Orientation = (Contracts.Orientation)Enum.Parse(typeof(Contracts.Orientation), currPosSplit[1]);

                moves = readText[2].Trim();

                return Rover;
            }
            catch (Exception ex)
            {
                throw new Exception("File parsing failed - " + ex.Message);
            }
        }
    }
}

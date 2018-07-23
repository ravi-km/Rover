using System;

namespace TheUltimateMARSRover
{
    public static class RoverHelper
    {
        public static int MoveOnY(int newY, int maxY)
        {
            if (newY > maxY || newY < 0)
                throw new ApplicationException("Rover tried to breach Y-axis");
            return newY;
        }

        public static int MoveOnX(int newX, int maxX)
        {
            if (newX > maxX || newX < 0)
                throw new ApplicationException("Rover tried to breach X-axis");
            return newX;
        }
    }
}

using System;

namespace TheUltimateMARSRover.Contracts
{
    public class UltimateRover : Rover
    {
        public override void ExecuteCommand(string command)
        {
            foreach (char item in command)
            {
                switch (item)
                {
                    case 'M':
                        this.Move(1);
                        break;
                    case 'L':
                        this.TurnLeft(1);
                        break;
                    case 'R':
                        this.TurnRight(1);
                        break;
                }
            }
        }

        public override void Move(int step)
        {
            int newY = 0;
            int newX = 0;

            try
            {
                switch (this.Orientation)
                {
                    case Orientation.N:
                        newY = this.CurrPosition.Y + step;
                        this.CurrPosition.Y = RoverHelper.MoveOnY(newY, this.Landscape.Y);
                        break;

                    case Orientation.S:
                        newY = this.CurrPosition.Y - step;
                        this.CurrPosition.Y = RoverHelper.MoveOnY(newY, this.Landscape.Y);
                        break;

                    case Orientation.E:
                        newX = this.CurrPosition.X + step;
                        this.CurrPosition.X = RoverHelper.MoveOnX(newX, this.Landscape.X);
                        break;

                    case Orientation.W:
                        newX = this.CurrPosition.X - step;
                        this.CurrPosition.X = RoverHelper.MoveOnX(newX, this.Landscape.X);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Execute command failed - " + ex.Message);
            }
        }

        public override void TurnLeft(int noOfTurns)
        {
            for (int i = 0; i < noOfTurns; i++)
            {
                switch (this.Orientation)
                {
                    case Orientation.N:
                        this.Orientation = Orientation.W;
                        break;
                    case Orientation.S:
                        this.Orientation = Orientation.E;
                        break;
                    case Orientation.E:
                        this.Orientation = Orientation.N;
                        break;
                    case Orientation.W:
                        this.Orientation = Orientation.S;
                        break;
                }
            }
        }

        public override void TurnRight(int noOfTurns)
        {
            for (int i = 0; i < noOfTurns; i++)
            {
                switch (this.Orientation)
                {
                    case Orientation.N:
                        this.Orientation = Orientation.E;
                        break;
                    case Orientation.S:
                        this.Orientation = Orientation.W;
                        break;
                    case Orientation.E:
                        this.Orientation = Orientation.S;
                        break;
                    case Orientation.W:
                        this.Orientation = Orientation.N;
                        break;
                }
            }
        }
    }
}

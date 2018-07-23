namespace TheUltimateMARSRover.Contracts
{
    public abstract class Rover : IRover
    {
        public Position CurrPosition { get; set; }

        public Position Landscape { get; set; }

        public Orientation Orientation { get; set; }

        public abstract void ExecuteCommand(string command);

        public abstract void Move( int step);

        public abstract void TurnLeft(int noOfTurns);

        public abstract void TurnRight(int noOfTurns);
    }
}
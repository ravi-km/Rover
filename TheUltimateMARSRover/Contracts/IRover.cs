namespace TheUltimateMARSRover
{
    interface IRover
    {
        void Move(int step);

        void TurnRight(int noOfTurns);

        void TurnLeft(int noOfTurns);

        void ExecuteCommand(string command);
    }
}

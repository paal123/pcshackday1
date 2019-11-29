using PcsHackday1.Models;

namespace PcsHackday1.Services
{
    public class RobotService : IRobotService
    {
        public MoveResult Move(RobotMove robotMove)
        {
            return new MoveResult
            {
                Result = 10,
                Duration = 13.37m
            };
        }
    }
}

using PcsHackday1.Models;

namespace PcsHackday1.Services
{
    public interface IRobotService
    {
        MoveResult Move(RobotMove robotMove);
    }
}

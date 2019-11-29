using System.Collections.Generic;

namespace PcsHackday1.Models
{
    public class RobotMove
    {
        public StartingPosition Start { get; set; }
        public List<MoveCommand> Commands { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcsHackday1
{
    public class Vector
    {
        public int posx;
        public int posy;
        public int length;

        public Vector Navigate(Direction direction, int length)
        {
            var v = new Vector { posx = this.posx, posy = this.posy};
            switch (direction)
            {
                case Direction.north:
                    posy-=length;
                    break;
                case Direction.south:
                    posy+=length;
                    break;
                case Direction.east:
                    posx+=length;
                    break;
                case Direction.west:
                    posx += length;
                    break;
            }

            return v;
        }
    }

    public enum Direction
    {
        north,
        south,
        east,
        west
    }
}

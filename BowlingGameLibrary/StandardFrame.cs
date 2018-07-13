using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLibrary
{
    class StandardFrame : Frame
    {
        public StandardFrame(int firstRollScore, int secondRollScore) 
            : base(firstRollScore, secondRollScore)
        {
        }

        public override int GetScore()
        {
            return FirstRollScore + SecondRollScore;
        }
    }
}

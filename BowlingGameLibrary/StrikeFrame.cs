using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLibrary
{
    class StrikeFrame : Frame
    {
        private int bonus;
        public StrikeFrame(int firstBonusRollScore, int secondBonusRollScore) 
            : base( 10, 0)
        {
            bonus = firstBonusRollScore + secondBonusRollScore;
        }

        public override int GetScore()
        {
            return 10 + bonus;
        }
    }
}

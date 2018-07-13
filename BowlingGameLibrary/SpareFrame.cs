using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLibrary
{
    class SpareFrame : Frame
    {
        private int bonus;
        public SpareFrame(int firstRollScore, int secondRollScore, int nextBonusRollScore) 
            : base(firstRollScore, secondRollScore)
        {
            bonus = nextBonusRollScore;
        }

        public override int GetScore()
        {
            return 10 + bonus;
        }
    }
}

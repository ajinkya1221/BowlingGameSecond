using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLibrary
{
    public abstract class Frame
    {

        public int FirstRollScore { get; protected set; }

        public int SecondRollScore { get; protected set; }

        abstract public int GetScore();

        public Frame(int firstRollScore, int secondRollScore)
        {
            this.FirstRollScore = firstRollScore;
            this.SecondRollScore = secondRollScore;
        }
    }
}

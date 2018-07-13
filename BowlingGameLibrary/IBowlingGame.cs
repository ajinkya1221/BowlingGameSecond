using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLibrary
{
    public interface IBowlingGame
    {
        int GetScore();
        void Roll(int pinsKnocked);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameLibrary
{
    public class TenPinBowlingGame : IBowlingGame
    {
        private List<int> _rollsList;
        private List<Frame> _frameList;
        private int _rollCount;

        public TenPinBowlingGame()
        {
            _rollsList = new List<int>();
            _frameList = new List<Frame>();
        }

        public void Roll(int pinsKnocked)
        {
            _rollsList.Add(pinsKnocked);
        }

        public int GetScore()
        {
            CreateFrames();

            return _frameList.Sum(f => f.GetScore());
        }

        private void CreateFrames()
        {
            for (int i = 0; i < 10; i++)
            {
                if (IsStrike())
                {
                    _rollCount++;
                    _frameList.Add(new StrikeFrame(_rollsList[_rollCount], _rollsList[_rollCount + 1]));
                }
                else if (IsSpare())
                {
                    _frameList.Add(new SpareFrame(_rollsList[_rollCount], _rollsList[_rollCount + 1], _rollsList[_rollCount + 2]));
                    _rollCount = _rollCount + 2;
                }
                else
                {
                    _frameList.Add(new StandardFrame(_rollsList[_rollCount], _rollsList[_rollCount + 1]));
                    _rollCount = _rollCount + 2;
                }
            }
        }
        
        private bool IsStrike()
        {
            return _rollsList[_rollCount] == 10;
        }

        private bool IsSpare()
        {
            return _rollsList[_rollCount] + _rollsList[_rollCount + 1] == 10;
        }
    }
}

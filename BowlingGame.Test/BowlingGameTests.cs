using System;
using BowlingGameLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGame.Test
{
    [TestClass]
    public class BowlingGameTests
    {
        IBowlingGame game;
        [TestInitialize]
        public void Init()
        {
            game = new TenPinBowlingGame();
        }

        private void ManyRolls(int score, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(score);
            }
        }

        [TestMethod]
        public void RandomRollsTest()
        {
            ManyRolls(3, 20);
            Assert.AreEqual(60, game.GetScore());
        }

        [TestMethod]
        public void AllStrikeTest()
        {
            ManyRolls(10, 12);
            Assert.AreEqual(300, game.GetScore());
        }

        [TestMethod]
        public void AllSpareTest()
        {
            ManyRolls(5, 21);
            Assert.AreEqual(150, game.GetScore());
        }

        [TestMethod]
        public void AllNoScoreTest()
        {
            ManyRolls(0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        [TestMethod]
        public void RandomStrikeTest()
        {
            ManyRolls(3, 8);
            game.Roll(10);
            ManyRolls(3, 10);
            Assert.AreEqual(70, game.GetScore());
        }

        [TestMethod]
        public void RandomSpareTest()
        {
            ManyRolls(3, 8);
            game.Roll(5);
            game.Roll(5);
            ManyRolls(3, 10);
            Assert.AreEqual(67, game.GetScore());
        }

        [TestMethod]
        public void LastSpareTest()
        {
            ManyRolls(3, 18);
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);
            Assert.AreEqual(67, game.GetScore());
        }

        [TestMethod]
        public void LastStrikeTest()
        {
            ManyRolls(3, 18);
            game.Roll(10);
            game.Roll(3);
            game.Roll(3);
            Assert.AreEqual(70, game.GetScore());
        }

    }
}

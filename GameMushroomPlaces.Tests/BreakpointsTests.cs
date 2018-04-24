using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameMushroomPlaces.Tests
{
    [TestClass]
    public class BreakpointsTests
    {
        private Breakpoints breakpoints = new Breakpoints();

        private const int COUNT_BREAKPOINTS = 12;
        private const int COUNT_PAIRS_BREAKPOINTS = 66;
        private const int ID_PLAYER = 1;
        private const int ARITHMETIC_LENGTH = 8;

        private int[,] GAME_LOCATION = new int[10, 10]{
            {1,0,0,0,0,0,0,0,0,3},
            {0,0,0,0,0,0,0,0,0,0},
            {3,0,0,0,0,0,0,3,0,0},
            {0,0,0,3,0,3,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,3},
            {0,3,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,3,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0,0,0},
            {3,0,0,0,0,0,0,3,0,2}
            };

        [TestMethod]
        public void TestValidateGatCountPairsBreakpoints()
        {
            // Arrange
            int countPairs = 0;

            // Act
            countPairs = breakpoints.GetCoutPairs(COUNT_BREAKPOINTS);

            // Assert
            Assert.AreEqual(COUNT_PAIRS_BREAKPOINTS, countPairs);
        }

        [TestMethod]
        public void TestValidateGetArithmeticLenght()
        {
            // Arrange
            int sumLenght = 0;
            int arithmeticLenght = 0;

            // Act
            breakpoints.GetArrayAllBreakpoints(GAME_LOCATION);
            breakpoints.GetCoutPairs(COUNT_BREAKPOINTS);

            sumLenght = breakpoints.GetArrayLeghtPairsKT(COUNT_PAIRS_BREAKPOINTS, ID_PLAYER);
            arithmeticLenght = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(sumLenght / COUNT_PAIRS_BREAKPOINTS)));

            // Assert
            Assert.AreEqual(ARITHMETIC_LENGTH, arithmeticLenght);
        }
    }
}

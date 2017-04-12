using ApprovalTests;
using ApprovalTests.Reporters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingKata.Tests
{
    [TestClass]
    [UseReporter(typeof(DiffReporter))]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bowlingGame = new BowlingGame();
            bowlingGame.Rolls(
                5, 3,
                6, 4,
                2, 7,
                10,
                4, 5,
                3, 7,
                10,
                10,
                8, 1,
                10, 10, 10);

            Approvals.Verify(bowlingGame.ToString());
        }
    }
}
using NUnit.Framework;
using LongestIncSubseqApi;
using System;

namespace LongestIncSubseqTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        [TestCase]
        public void SolveTest1()
        {
            LongestIncSubseqApi.LongestIncSubseq obj = new LongestIncSubseqApi.LongestIncSubseq();
            string input = "6 2 4 6 1 5 9 2";
            string expected = "2 4 6";

            obj.Solve(Array.ConvertAll<string, int>(input.ToString().Split(' '), Convert.ToInt32));
            Assert.AreEqual(expected, obj.output);
        }
    }
}
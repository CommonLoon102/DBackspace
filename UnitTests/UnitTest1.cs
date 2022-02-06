using DBackspace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod01()
        {
            Assert.IsTrue(new Solver("abcbd", "bd").IsSolvable());
        }

        [TestMethod]
        public void TestMethod02()
        {
            Assert.IsTrue(new Solver("abcaa", "a").IsSolvable());
        }

        [TestMethod]
        public void TestMethod03()
        {
            Assert.IsTrue(new Solver("ababa", "ba").IsSolvable());
        }

        [TestMethod]
        public void TestMethod04()
        {
            Assert.IsFalse(new Solver("ababa", "bb").IsSolvable());
        }

        [TestMethod]
        public void TestMethod05()
        {
            Assert.IsFalse(new Solver("aaa", "aaaa").IsSolvable());
        }

        [TestMethod]
        public void TestMethod06()
        {
            Assert.IsTrue(new Solver("aababa", "ababa").IsSolvable());
        }

        [TestMethod]
        public void TestMethod07()
        {
            Assert.IsFalse(new Solver("aba", "ab").IsSolvable());
        }

        [TestMethod]
        public void TestMethod08()
        {
            Assert.IsFalse(new Solver("abaasdfaasdfasdf", "bsdfsdfasd").IsSolvable());
        }

        [TestMethod]
        public void TestMethod09()
        {
            Assert.IsTrue(new Solver("abaasdfaasdfasdf", "faas").IsSolvable());
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.IsFalse(new Solver("abaasdfaasdfasdf2", "faas").IsSolvable());
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.IsTrue(new Solver("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxabaasdfaasdfasdf", "faas").IsSolvable());
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.IsTrue(new Solver("abxbba", "abba").IsSolvable());
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.IsTrue(new Solver("xxxaabaababababyyyyca", "abca").IsSolvable());
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.IsFalse(new Solver("xxxbaababababyyyca", "abca").IsSolvable());
        }
    }
}
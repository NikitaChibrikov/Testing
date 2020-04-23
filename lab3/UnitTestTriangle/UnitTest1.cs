using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;

namespace UnitTestTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool result = Program.TriangleExeption(2, 3, 8);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            bool result = Program.TriangleExeption(-2, 3, 4);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            bool result = Program.TriangleExeption(10, 100, 1);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            bool result = Program.TriangleExeption(3, 4, 5);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod5()
        {
            bool result = Program.TriangleExeption(2, 2, 1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            bool result = Program.TriangleExeption(1, 1, 1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestMethod7()
        {
            bool result = Program.TriangleExeption(-2, -3, -4);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            bool result = Program.TriangleExeption(2, -3, 0);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            bool result = Program.TriangleExeption(2, 0, 4);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestMethod10()
        {
            bool result = Program.TriangleExeption(0, -3, 4);
            Assert.AreEqual(false, result);
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;

namespace UnitTestTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestParam_2_3_4()
        {
            bool result = Program.TriangleExeption(2, 3, 8);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestParam_minus2_3_4()
        {
            bool result = Program.TriangleExeption(-2, 3, 4);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestParam_10_100_1()
        {
            bool result = Program.TriangleExeption(10, 100, 1);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestParam_3_4_5()
        {
            bool result = Program.TriangleExeption(3, 4, 5);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestParam_2_2_1()
        {
            bool result = Program.TriangleExeption(2, 2, 1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestParam_1_1_1()
        {
            bool result = Program.TriangleExeption(1, 1, 1);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestParam_minus2_minus3_minus4()
        {
            bool result = Program.TriangleExeption(-2, -3, -4);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestParam_2_minus3_0()
        {
            bool result = Program.TriangleExeption(2, -3, 0);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestParam_2_0_4()
        {
            bool result = Program.TriangleExeption(2, 0, 4);
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void TestParam_0_minus3_4()
        {
            bool result = Program.TriangleExeption(0, -3, 4);
            Assert.AreEqual(false, result);
        }
    }
}

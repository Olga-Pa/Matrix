using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace Task2.Tests
{
    [TestClass]

    public class MatrixTests
    {
        private Matrix _matrix = new Matrix(3, 3);
        private Matrix _matrix2 = new Matrix(2, 2);
        [TestMethod]

        public void CheckMatrixDiagonalSums_isEqual_equal()
        {

            int[,] _test = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            _matrix.GenerateTestsMatrix(_test);
            Assert.AreEqual(15, _matrix.GetMatrixDiagonalSum());
        }
        [TestMethod]

        public void CheckMatrixDiagonalSums_isEqual_equal2()
        {
            int[,] _test2 = { { 1, 2 }, { 4, 5} };
            _matrix2.GenerateTestsMatrix(_test2);
            Assert.AreEqual(6, _matrix2.GetMatrixDiagonalSum());
        }
    }
}
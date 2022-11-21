using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace orm3.Tests
{
    [TestClass]
    public class UnitTest1
    {
        static Calc MyCalc = null;

        [ClassInitialize]
        static public void Init(TestContext tc)
        {
            MyCalc = new Calc();
        }

        [ClassCleanup]
        static public void Done()
        {
            MyCalc = null;
        }

        [TestMethod]
        public void Div_2div2_1expected()
        {
            //arrange
            int a = 2;
            int b = 2;
            float expected = 1;

            //act
            Calc MyCalc = new Calc();
            float actual = MyCalc.Div(a, b);

            //assert
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException), "Деление на 0")]
        public void Div_2div0_exceptionexpected()
        {
            //arrange
            float a = 2;
            float b = 0;
            float expected = 2;

            //act

            float actual = MyCalc.Div(a, b);

            //assert
            Assert.AreNotEqual(actual, expected);
        }
    }
}
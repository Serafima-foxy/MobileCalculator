using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UITest_Calculator
{
    public class TestClass
    {
        MainScreenModel _msModel = new MainScreenModel();

        [SetUp]
        public void StartAppBeforeEachTest()
        {
            AppInitializer.StartApp();
        }

        [Test]
        public void EnterAllNumbers()
        {
            _msModel.TapOnOne()
                .TapOnTwo()
                .TapOnThree()
                .TapOnFour()
                .TapOnFive()
                .TapOnSix()
                .TapOnSeven()
                .TapOnEight()
                .TapOnNine()
                .TapOnZero();
            Assert.AreEqual("1234567890", _msModel.GetTextFromTextField());
        }
        [Test]
        public void PlusTwoNumbers()
        {
            _msModel.TapOnOne()
                .TapOnFour()
                .TapOnZero()
                .TapOnPlus()
                .TapOnTwo()
                .TapOnSeven()
                .TapOnEqual();
            Assert.AreEqual("167", _msModel.GetTextFromTextField());
        }

        [Test]
        public void MinusTwoNumbers()
        {
            _msModel.TapOnThree()
                .TapOnMinus()
                .TapOnFour()
                .TapOnEqual();
            Assert.AreEqual("-1", _msModel.GetTextFromTextField());
        }

        [Test]
        public void DivideTwoNumbers()
        {
            _msModel.TapOnFive()
                .TapOnDivide()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("2.5", _msModel.GetTextFromTextField());
        }

        [Test]
        public void MultiplyThreeNumbers()
        {
            _msModel.TapOnSix()
                .TapOnMultiply()
                .TapOnSeven()
                .TapOnMultiply()
                .TapOnEight()
                .TapOnEqual();
            Assert.AreEqual("336", _msModel.GetTextFromTextField());
        }

        [Test]
        public void CalculationWithFrictional()
        {
            _msModel.TapOnNine()
                .TapOnComma()
                .TapOnSeven()
                .TapOnPlus()
                .TapOnOne()
                .TapOnEqual();
            Assert.AreEqual("10.7", _msModel.GetTextFromTextField());
        }

        [Test]
        public void DelFromTextField()
        {
            _msModel.TapOnThree()
                .TapOnZero()
                .TapOnSix()
                .TapOnTwo()
                .TapOnMultiply()
                .TapOnDEL();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }

        [Test]
        public void CheckCalcWithTwoOperatorsInRow()
        {
            _msModel.TapOnFive()
                .TapOnNine()
                .TapOnMultiply()
                .TapOnMinus()
                .TapOnNine()
                .TapOnOne()
                .TapOnEqual();
            Assert.AreEqual("-32", _msModel.GetTextFromTextField());
        }

        [Test]
        public void MultiplyByZero()
        {
            _msModel.TapOnEight()
                .TapOnMultiply()
                .TapOnZero()
                .TapOnEqual();
            Assert.AreEqual("0", _msModel.GetTextFromTextField());
        }

        [Test]
        public void DivideByZero()
        {
            _msModel.TapOnThree()
                .TapOnDivide()
                .TapOnZero()
                .TapOnEqual();
            Assert.AreEqual("Infinity", _msModel.GetTextFromTextField());
        }
        
        [Test]
        public void CheckLongCalculation()
        {
            _msModel.TapOnSeven()
                .TapOnOne()
                .TapOnPlus()
                .TapOnNine()
                .TapOnFour()
                .TapOnDivide()
                .TapOnOne()
                .TapOnZero()
                .TapOnMinus()
                .TapOnSix()
                .TapOnEqual();
            Assert.AreEqual("10.5", _msModel.GetTextFromTextField());
        }

        [Test]
        public void CalculationsAfterEqual()
        {
            _msModel.TapOnFive()
                .TapOnDivide()
                .TapOnFive()
                .TapOnEqual()
                .TapOnMinus()
                .TapOnFour()
                .TapOnEqual()
                .TapOnMultiply()
                .TapOnNine()
                .TapOnEqual();
            Assert.AreEqual("-27", _msModel.GetTextFromTextField());
        }
    }
}

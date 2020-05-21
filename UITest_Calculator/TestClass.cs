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
                .TapOnPlus()
                .TapOnTwo()
                .TapOnEqual();
            Assert.AreEqual("3", _msModel.GetTextFromTextField());
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
    }
}

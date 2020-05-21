using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace UITest_Calculator
{
    public class MainScreenModel
    {
        public static IApp App => AppInitializer.App;

        public Query textField = x => x.Id("input");
        public Query btnDEL = x => x.Marked("DEL");
        public Query btnZero = x => x.Marked("0");
        public Query btnOne = x => x.Marked("1");
        public Query btnTwo = x => x.Marked("2");
        public Query btnThree = x => x.Marked("3");
        public Query btnFour = x => x.Marked("4");
        public Query btnFive = x => x.Marked("5");
        public Query btnSix = x => x.Marked("6");
        public Query btnSeven = x => x.Marked("7");
        public Query btnEight = x => x.Marked("8");
        public Query btnNine = x => x.Marked("9");
        public Query btnComma = x => x.Marked(",");
        public Query btnPlus = x => x.Marked("+");
        public Query btnMinus = x => x.Marked("-");
        public Query btnMultiply = x => x.Marked("*");
        public Query btnDivide = x => x.Marked("/");
        public Query btnEqual = x => x.Marked("=");

        public MainScreenModel TapOnOne()
        {
            App.Tap(btnOne);
            return this;
        }
        public MainScreenModel TapOnTwo()
        {
            App.Tap(btnTwo);
            return this;
        }
        public MainScreenModel TapOnThree()
        {
            App.Tap(btnThree);
            return this;
        }
        public MainScreenModel TapOnFour()
        {
            App.Tap(btnFour);
            return this;
        }
        public MainScreenModel TapOnFive()
        {
            App.Tap(btnFive);
            return this;
        }
        public MainScreenModel TapOnSix()
        {
            App.Tap(btnSix);
            return this;
        }
        public MainScreenModel TapOnSeven()
        {
            App.Tap(btnSeven);
            return this;
        }
        public MainScreenModel TapOnEight()
        {
            App.Tap(btnEight);
            return this;
        }
        public MainScreenModel TapOnNine()
        {
            App.Tap(btnNine);
            return this;
        }
        public MainScreenModel TapOnZero()
        {
            App.Tap(btnZero);
            return this;
        }
        public MainScreenModel TapOnPlus()
        {
            App.Tap(btnPlus);
            return this;
        }
        public MainScreenModel TapOnMinus()
        {
            App.Tap(btnMinus);
            return this;
        }
        public MainScreenModel TapOnMultiply()
        {
            App.Tap(btnMultiply);
            return this;
        }
        public MainScreenModel TapOnDivide()
        {
            App.Tap(btnDivide);
            return this;
        }
        public MainScreenModel TapOnComma()
        {
            App.Tap(btnComma);
            return this;
        }
        public MainScreenModel TapOnEqual()
        {
            App.Tap(btnEqual);
            return this;
        }
        public MainScreenModel TapOnDEL()
        {
            App.Tap(btnDEL);
            return this;
        }

        public string GetTextFromTextField()
        {
            return App.Query(textField)[0].Text.Trim();
        }
    }
}

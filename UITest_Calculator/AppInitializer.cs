using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace UITest_Calculator
{
    public static class AppInitializer
    {
        static IApp _app;
        private static string _simID = null;
        private static string _apkPath = @"C:\SERA\Xamarin\MobileCalculator\MobileCalculator\bin\Release\com.companyname.mobilecalculator.apk";

        public static IApp App
        {
            get { return _app; }
        }

        public static void StartApp()
        {
            var configuratorAndroid = ConfigureApp.Android.EnableLocalScreenshots();
            if (_simID != null)
            {
                configuratorAndroid.DeviceSerial(_simID);
            }
            _app = configuratorAndroid.ApkFile(_apkPath).StartApp();
        }

    }
}

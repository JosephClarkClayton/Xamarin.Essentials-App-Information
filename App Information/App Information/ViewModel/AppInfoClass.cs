using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AppInformation.ViewModel
{
   public class AppInfoClass
{

        public string appName { get; private set; }
        public string packageName { get;private set; }
        public string version { get; private set; }
        public string build { get; private set; }
        public ICommand ShowSettingsUICommand { get; private set; }


        public AppInfoClass()
        {
            appName = AppInfo.Name;
            packageName = AppInfo.PackageName;
            version = AppInfo.VersionString;
            build = AppInfo.BuildString;

            ShowSettingsUICommand = new Command(() =>
            {

                AppInfo.ShowSettingsUI();

            });

        }

}



}

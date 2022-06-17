using System;
using WakeMe.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WakeMe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ToDoListPage());
        }
        
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

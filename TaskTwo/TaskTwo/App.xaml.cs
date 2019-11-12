using System;
using System.Threading;
using Xamarin.Forms;

namespace TaskTwo
{
    public partial class App : Application
    {
        const double PERIOD = 30.0;
        bool alive;
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage { Title = "Main page"});
            alive = true;
            Device.StartTimer(TimeSpan.FromSeconds(PERIOD), OnTimerTick);
        }
        
        protected override void OnStart()
        {
            // Handle when your app starts
            OutputPopup("OnStart");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            OutputPopup("OnSleep");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            OutputPopup("OnResume");
        }

        private bool OnTimerTick()
        {
            OutputPopup(DateTime.Now.ToString("T"));
            return alive;
        }

        public async void OutputPopup(string message)
        {
            await App.Current.MainPage.DisplayAlert(
                    "Message",
                    message,
                    "Ok");
        }
    }
}

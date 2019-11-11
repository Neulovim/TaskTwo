using System.Threading;
using Xamarin.Forms;

namespace TaskTwo
{
    public partial class App : Application
    {
        PopupManager popupManager;
        ThreadManager threadManager;
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage { Title = "Main page"});
            popupManager = new PopupManager();
            threadManager = new ThreadManager();
            Thread myThread = threadManager.GetThread();
            myThread.Start();
        }
        
        protected override void OnStart()
        {
            // Handle when your app starts
            popupManager.OutputPopup("OnStart");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            popupManager.OutputPopup("OnSleep");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            popupManager.OutputPopup("OnResume");
        }
    }
}

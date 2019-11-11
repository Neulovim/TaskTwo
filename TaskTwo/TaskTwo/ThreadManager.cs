using System;
using System.Threading;
using Xamarin.Forms;

namespace TaskTwo
{
    class ThreadManager
    {
        const double PERIOD = 30.0;
        bool alive;
        Thread myThread;
        PopupManager popupManager;
        public Thread GetThread()
        {
            alive = true;
            popupManager = new PopupManager();
            myThread = new Thread(new ThreadStart(StartTimer));
            return myThread;
        }
        private void StartTimer()
        {
            Device.StartTimer(TimeSpan.FromSeconds(PERIOD), OnTimerTick);
        }
        private bool OnTimerTick()
        {
            popupManager.OutputPopup(DateTime.Now.ToString("T"));
            return alive;
        }
    }
}

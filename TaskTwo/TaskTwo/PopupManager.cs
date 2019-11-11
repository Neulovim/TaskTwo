
namespace TaskTwo
{
    class PopupManager 
    {
        public async void OutputPopup(string message)
        {
            await App.Current.MainPage.DisplayAlert(
                    "Message",
                    message,
                    "Ok");
        }
    }
}

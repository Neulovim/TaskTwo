using System;
using Xamarin.Forms;

namespace TaskTwo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnNextPageTwoButtomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PageTwo { Title = "Page two"});
        }
    }
}

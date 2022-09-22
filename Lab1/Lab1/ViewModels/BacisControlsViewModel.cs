using System;
using Lab1.Views;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Lab1.ViewModels
{
    public class BasicControlsViewModel : BaseViewModel
    {
        public Command SubmitCommand { get; }
        public Command CancelCommand { get; }
        public BasicControlsViewModel()
        {
            Title = "Basic Controls";
            SubmitCommand = new Command(SubmitClicked);
            CancelCommand = new Command(CancelClicked);
        }

        private async void SubmitClicked(object obj)
        {
            await App.Current.MainPage.DisplayAlert("Alert", "Submitted", "OK");
        }
        private async void CancelClicked(object obj)
        {
            await App.Current.MainPage.DisplayAlert("Alert", "Cancelled", "OK");
        }
    }
}

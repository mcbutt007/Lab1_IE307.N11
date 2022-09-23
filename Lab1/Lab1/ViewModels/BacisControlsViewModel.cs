using System;
using Lab1.Views;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.ComponentModel;

namespace Lab1.ViewModels
{
    public class BasicControlsViewModel : INotifyPropertyChanged
    {
        private string entUsrName = string.Empty, entUsrEmail = string.Empty, 
            entUsrPhone = string.Empty, dpkUsrDOB = string.Empty, 
            swUsrGender = string.Empty;
        private bool isToggled = false;
        public String EntUsrName
        {
            get { return entUsrName; }
        }
        public string EntUsrEmail
        {
            get { return entUsrEmail; }
        }
        public string EntUsrPhone
        {
            get { return entUsrPhone; }
        }
        public string DpkUsrDOB
        {
            get { return dpkUsrDOB; }
        }

        public string SwUsrGender
        {
            get { return swUsrGender; }
        }
        public Command SubmitBtn { get; }
        public Command CancelBtn { get; }
        public String Title { get { return "Basic Controls"; } }
        public BasicControlsViewModel()
        {
            SubmitBtn = new Command(SubmitClicked);
            CancelBtn = new Command(CancelClicked);
        }

        public event PropertyChangedEventHandler PropertyChanged;

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

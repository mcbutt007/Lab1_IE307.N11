using System;
using Lab1.Views;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lab1.ViewModels
{
    public class BasicControlsViewModel : INotifyPropertyChanged
    {
        private string entUsrName = string.Empty,
            entUsrEmail = string.Empty, 
            entUsrPhone = string.Empty;
        private bool swUsrGender = false;
        private DateTime dpkUsrDOB = DateTime.Today; 
        public String EntUsrName
        {
            get => entUsrName;
            set
            {
                entUsrName = value;
                OnPropertyChanged();
            }
        }
        public string EntUsrEmail
        {
            get => entUsrEmail; 
            set
            {
                entUsrEmail = value;
                OnPropertyChanged();
            }
        }
        public string EntUsrPhone
        {
            get => entUsrPhone; 
            set
            {
                entUsrPhone = value;
                OnPropertyChanged();
            }   
        }
        public DateTime DpkUsrDOB
        {
            get => dpkUsrDOB; 
            set
            {
                dpkUsrDOB = value;
                OnPropertyChanged();
            }   
        }

        public bool SwUsrGender
        {
            get => swUsrGender; set
            {
                swUsrGender = value;
                OnPropertyChanged();
            } 
        }
        public Command SubmitBtn { get; }
        public Command CancelBtn { get; }
        public String Title { get => "Basic Controls"; }
        public BasicControlsViewModel()
        {
            SubmitBtn = new Command(SubmitClicked);
            CancelBtn = new Command(CancelClicked);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void CancelClicked(object obj)
        {
            entUsrName = String.Empty;
            entUsrEmail = String.Empty;
            entUsrPhone = String.Empty;
            dpkUsrDOB = DateTime.Today;
            swUsrGender = false;
            OnPropertyChanged(nameof(EntUsrName));
            OnPropertyChanged(nameof(EntUsrEmail));
            OnPropertyChanged(nameof(EntUsrPhone));
            OnPropertyChanged(nameof(DpkUsrDOB));
            OnPropertyChanged(nameof(SwUsrGender));
        }
        private async void SubmitClicked(object obj)
        {
            string UsrGender = "Female";
            if (swUsrGender)
                UsrGender = "Male";

            string messageContent = "Name: " + entUsrName + "\n Email: " + entUsrEmail
                + "\n Phone: " + entUsrPhone + "\n Birthday: " + dpkUsrDOB.Date +
                "\n Gender: " + UsrGender;
            await App.Current.MainPage.DisplayAlert("Message", messageContent, "OK");
        }
    }
}

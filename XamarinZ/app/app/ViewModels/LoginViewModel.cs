

namespace app.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    public class LoginViewModel:BaseViewModel
    {

        #region Attributes
        string email;
        string password;
        bool isrunning;
        #endregion

        #region Properties
        public string Email {
            get
            {
                return this.email;
            }
                 set
            {
                SetValue(ref this.email, value);
            }
        }
        public string Password {
            get
            {
                return this.password;
            }
            set
            {
                SetValue(ref this.password, value);
            }
        }
        public bool IsRunning {
            get
            {
                return this.isrunning;
            }
            set
            {
                SetValue(ref this.isrunning, value);
            }
        }

        #endregion

        #region Commands
        public ICommand LoginCommand {
            get
            {
                return new RelayCommand(cmdLogin);
            }
        }

        private async void cmdLogin()
        {
            if (String.IsNullOrEmpty(Email))
            {
               await App.Current.MainPage.DisplayAlert("Email empty", "Please input email","Accept");
                return;
            }
            if (String.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Password empty", "Please input password", "Accept");
                return;
            }
        }
        #endregion

    }
}

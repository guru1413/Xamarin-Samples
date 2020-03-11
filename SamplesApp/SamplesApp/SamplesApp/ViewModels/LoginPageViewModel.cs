using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using SamplesApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SamplesApp.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        readonly IPageDialogService _dialogService;

        private string _emailId = string.Empty;
        public string EmailId
        {
            get { return _emailId; }
            set { SetProperty(ref _emailId, value); }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        private DelegateCommand _loginCommand;
        public DelegateCommand LoginCommand =>
            _loginCommand ?? (_loginCommand = new DelegateCommand(ExecuteLoginCommand));

        private DelegateCommand<string> _buttonTappedCommand;
        public DelegateCommand<string> ButtonTappedCommand =>
            _buttonTappedCommand ?? (_buttonTappedCommand = new DelegateCommand<string>(ExecuteButtonTappedCommand));


        public LoginPageViewModel(INavigationService navigationService,
                                  IPageDialogService dialogService) : base(navigationService)
        {
            _dialogService = dialogService;
        }

        void ExecuteLoginCommand()
        {
            if (!Regex.IsMatch(EmailId, Constants.EMAIL_REGEX, RegexOptions.IgnoreCase))
            {
                _dialogService.DisplayAlertAsync(Constants.ALERT, Constants.EMAIL_ERROR_MESSAGE, Constants.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                _dialogService.DisplayAlertAsync(Constants.ALERT, Constants.PASSWORD_ERROR_MESSAGE, Constants.OK);
                return;
            }

            _dialogService.DisplayAlertAsync(Constants.SUCCESS, Constants.LOGIN_SUCCESS_MESSAGE, Constants.OK);
        }

        void ExecuteButtonTappedCommand(string message)
        {
            _dialogService.DisplayAlertAsync(Constants.ALERT, message, Constants.OK);
        }
    }
}

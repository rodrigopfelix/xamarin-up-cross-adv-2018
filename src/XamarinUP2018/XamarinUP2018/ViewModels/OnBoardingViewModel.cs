﻿using Prism.Commands;
using Prism.Navigation;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using XamarinUP2018.Views;

namespace XamarinUP2018.ViewModels
{
    public sealed class OnBoardingViewModel : ViewModelBase
    {
        public OnBoardingViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            GoHome = new DelegateCommand(async () => await ExecuteGoHome());
        }

        private Task ExecuteGoHome() 
            => NavigationService.NavigateAsync($"{nameof(HomePage)}");

        public ICommand GoHome { get; }
    }
}

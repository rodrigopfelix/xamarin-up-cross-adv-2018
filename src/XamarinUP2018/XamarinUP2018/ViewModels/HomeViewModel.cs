﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace XamarinUP2018.ViewModels
{
    public sealed class HomeViewModel : ViewModelBase
    {
        private readonly IPageDialogService pageDialogService;

        public HomeViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService): base (navigationService)
        {
            this.pageDialogService = pageDialogService;
            ShowAlert = new DelegateCommand(async () => await ExecuteShowAllert());
        }

        private string text;
        public string Text {
            get => text;
            set => SetProperty(ref text, value);
        }

        public ICommand ShowAlert { get; }

        private async Task ExecuteShowAllert()
        {
            await ExecuteBusyAction(async() => {
                await pageDialogService.DisplayAlertAsync("Hello", "The Message", "Ok");
            });
        }

    }
}

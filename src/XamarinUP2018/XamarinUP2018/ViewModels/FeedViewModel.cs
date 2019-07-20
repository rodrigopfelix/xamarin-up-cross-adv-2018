using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Navigation;
using Xamarin.Forms;
using XamarinUP2018.Services;

namespace XamarinUP2018.ViewModels
{
    public sealed class FeedViewModel : ViewModelBase
    {
        private readonly IFeedService feedService;

        public FeedViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
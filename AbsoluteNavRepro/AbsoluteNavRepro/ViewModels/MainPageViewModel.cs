using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsoluteNavRepro.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public DelegateCommand AbsoluteNavigateCommand { get; set; }
        public DelegateCommand NavigateCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";


            NavigateCommand = new DelegateCommand(async () =>
            {
                await Task.Delay(2000);
                await NavigationService.NavigateAsync("MainPage");
            });

            AbsoluteNavigateCommand = new DelegateCommand(async () =>
            {
                await Task.Delay(2000);
                await NavigationService.NavigateAsync("/MainPage");
            });
        }
    }
}

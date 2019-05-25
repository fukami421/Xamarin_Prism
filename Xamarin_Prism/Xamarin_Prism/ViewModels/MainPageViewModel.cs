using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin_Prism.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationService
    //public class MainPageViewModel : ViewModelBase, INavigationAware, IDestructible
    {
        #region fields
        protected INavigationService NavigationService { get; private set; }
        private readonly IPageDialogService PageDialogService;
        public DelegateCommand MoveToRegistrationCommand { get; }
        public DelegateCommand ShowAlertCommand { get; }
        private string text;
        public string Text
        {
            get { return this.text; }
            set { SetProperty(ref this.text, value); }
        }
        private string box;
        public string Box
        {
            get { return this.box; }
            set { SetProperty(ref this.box, value); }
        }
        #endregion

        #region constructers
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            this.Text = "Ryu1！Prism頑張ろ!!";
            this.NavigationService = navigationService;
            this.PageDialogService = pageDialogService;
            MoveToRegistrationCommand = new DelegateCommand(() =>
            {
                this.NavigationService.NavigateAsync("RegistrationPage");
            });

            ShowAlertCommand = new DelegateCommand(async () =>
            {
                await PageDialogService.DisplayAlertAsync("Alert", "Mainページやな, Ryu1.", "OK");
            });
        }

        public Task<INavigationResult> GoBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> GoBackAsync(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(Uri uri)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(Uri uri, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<INavigationResult> NavigateAsync(string name, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(NavigationParameters parameters)//画面へ遷移してきたタイミングで呼び出される
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)//別画面へ遷移するタイミングで呼び出される
        {

        }

        Task<INavigationResult> INavigationService.GoBackAsync()
        {
            throw new NotImplementedException();
        }

        Task<INavigationResult> INavigationService.GoBackAsync(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        Task<INavigationResult> INavigationService.NavigateAsync(Uri uri)
        {
            throw new NotImplementedException();
        }

        Task<INavigationResult> INavigationService.NavigateAsync(Uri uri, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        Task<INavigationResult> INavigationService.NavigateAsync(string name)
        {
            throw new NotImplementedException();
        }

        Task<INavigationResult> INavigationService.NavigateAsync(string name, INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
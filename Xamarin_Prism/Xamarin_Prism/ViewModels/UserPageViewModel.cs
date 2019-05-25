using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using Prism.Mvvm;
using System.Windows.Input;
using Xamarin_Prism.Views;
using Xamarin_Prism.Models;
using System.Diagnostics;

namespace Xamarin_Prism.ViewModels
{
    public class UserPageViewModel : BindableBase, INavigationService
    {
        #region fields
        protected INavigationService NavigationService { get; private set; }
        private readonly IPageDialogService PageDialogService;
        //public DelegateCommand MoveToMainPageCommand { get; }
        //public DelegateCommand MoveToUserPageCommand { get; }
        public DelegateCommand ShowAlertCommand { get; }
        private string text;
        public string Text
        {
            get { return this.text; }
            set { SetProperty(ref this.text, value); }
        }
        #endregion
        public UserPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            this.NavigationService = navigationService;
            this.PageDialogService = pageDialogService;
            //MoveToMainPageCommand = new DelegateCommand(async () =>
            //{
            //    await this.NavigationService.GoBackAsync();
            //});
            //MoveToUserPageCommand = new DelegateCommand(async () =>
            //{
            //    await this.NavigationService.NavigateAsync("UserPage");
            //});
            ShowAlertCommand = new DelegateCommand(async () =>
            {
                await PageDialogService.DisplayAlertAsync("Alert", "ユーザーページやな, Ryu1.", "OK");
            });
            this.InstantiateUserList();
        }

        private void InstantiateUserList()
        {
            var persons = new List<Person> {
                new Person { Name = "Taro", Age = 25},
                new Person { Name = "Jiro", Age = 22},
                new Person { Name = "Saburo", Age = 19},
                new Person { Name = "Shiro", Age = 16},
            };
            var persons20OrOlder = persons.Where(person => person.Age >= 20);
            foreach(var person2 in persons20OrOlder)
            {
                Debug.WriteLine("person2: " + person2.Name);
            }
            Debug.WriteLine("persons200Older: " + persons20OrOlder);
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
    }
}
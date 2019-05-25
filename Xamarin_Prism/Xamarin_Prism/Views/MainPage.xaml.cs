using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Prism.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, 50, 0, 0);
                    break;
                case Device.Android:
                    this.Padding = new Thickness(0, 50, 0, 0);
                    break;
                default:
                    this.Padding = new Thickness(0, 100, 0, 0);
                    break;
            }
        }
    }
}

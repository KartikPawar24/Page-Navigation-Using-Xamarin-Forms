using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Page_Navigation_Using_Xamarin_Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void OnBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page_Navigation_Using_Xamarin_Forms.MainPage());
        }
    }
}
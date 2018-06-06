using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Page_Navigation_Using_Xamarin_Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Onbtn_Clicked(object sender,EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}

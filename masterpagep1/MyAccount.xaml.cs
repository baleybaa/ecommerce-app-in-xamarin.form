using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace masterpagep1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyAccount : ContentPage
	{
		public MyAccount ()
		{
			InitializeComponent ();
		}

        private  void Rgstr_Clicked(object sender, EventArgs e)
        {
            overlay.IsVisible = true;
            overlay1.IsVisible = false;
        }

        private void Signin_Clicked(object sender, EventArgs e)
        {
            overlay1.IsVisible = true;
            overlay.IsVisible = false;
        }

        private void Cncll_Clicked(object sender, EventArgs e)
        {
            overlay.IsVisible = false;
        }
        private void Cncll1_Clicked(object sender, EventArgs e)
        {
            overlay1.IsVisible = false;
        }

        private void Enntr_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Signup page", "signup is successfull", "ok");

        }
        private void Enntr1_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("LOgin page", "Login is successfull", "ok");


        }

        //private async void Cross_Clicked(object sender, EventArgs e)
        //{
        //    overlay2.IsVisible = false;
        //    await Navigation.PushAsync(new profile());
        //}
     
    }
}
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
	public partial class Fashion : ContentPage
	{
		public Fashion ()
		{
			InitializeComponent ();
		}

        private void Tshirt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addcart());
        }
    }
}
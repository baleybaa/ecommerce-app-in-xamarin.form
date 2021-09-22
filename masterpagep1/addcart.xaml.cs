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
	public partial class addcart : ContentPage
	{
		public addcart ()
		{
			InitializeComponent ();
            var image = new List<string>
            {
              "http://www.involvinglondon.co.uk/image/cache/data/category_2/billabong-die-cut-long-sleeve-t-shirt-160g-combed-cotton-jersey-white-contrasting-sl-951-400x400.jpg",
              "https://s3.amazonaws.com/sav3-assets/wp-content/uploads/2018/05/04120217/SA-20401_Performance-Long-Sleeve-Shirt_White_Free-to-Hunt_BACK-400x400.jpg",
              "http://jarshia.com/wp-content/uploads/2017/12/MENS-VOLTAGE-SHIRT-400x400.jpg"

            };
            slider1.ItemsSource = image;
        }

        private void Cart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new wallet());
        }
    }
}
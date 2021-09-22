using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;
using Xamarin.Forms.Xaml;
using Application = Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat.Application;
using NavigationPage = Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat.NavigationPage;

namespace masterpagep1
{
    
        [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{    
    public Home ()
		{
                InitializeComponent();
            //var scroll = new ScrollView();
            //Content = scroll;
            //var abs = new AbsoluteLayout();
         
            var image = new List<string>
            {
                "https://image.shutterstock.com/image-vector/islamic-design-illustration-concept-happy-260nw-1448598323.jpg",
                "https://cdn.shopify.com/s/files/1/2635/3244/files/Main_Banner_1920x750_1920x_8fb1a2bc-874d-4ed6-9d62-efd50376bcb1.jpg?v=1556953056",
                "https://i.ytimg.com/vi/SnOfNvHAnzw/maxresdefault.jpg",
                "http://theworldnews.in/wp-content/uploads/2016/08/Khaadi-Lawn-Festive-Eid-Dresses-Collection-2016-for-Girls.jpg",
                "https://i.ytimg.com/vi/wDjGnWO_fG4/maxresdefault.jpg",
"https://www.jadegital.com/wp-content/uploads/1-4.jpg",
"https://thumbs.dreamstime.com/z/makeup-ads-template-charming-red-lipstick-mockup-sparkling-background-package-design-promotion-product-cosmetics-advertising-127485955.jpg",
"https://d2z1w4aiblvrwu.cloudfront.net/ad/ADTb/baskin-robbins-oreo-birthday-cake-large-10.jpg",
"https://i.ytimg.com/vi/8f4NWfi2DcM/maxresdefault.jpg",
"https://static01.nyt.com/images/2011/08/09/business/Adco/Adco-jumbo.jpg"


            };
            slider1.ItemsSource = image;
            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                slider1.Position = (slider1.Position + 1) % image.Count;
                return true;
            }));

        }

        private void Wallet_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new wallet());

        }

        private void Voicesearch_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new voicesearch());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new category());
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new offerzone());
        }

        private void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new topslection());

        }

        private void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new deals());

        }

        private void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new topslection());
        }

        private void TapGestureRecognizer_Tapped_5(object sender, EventArgs e)
        {

        }

        private void Jacket_Clicked(object sender, EventArgs e)
        {

        }

        private void Hood_Clicked(object sender, EventArgs e)
        {

        }

        private void TapGestureRecognizer_Tapped_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new industrycateg());
        }

        private void Selected_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Fashion());
        }

        private void Slected_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new topslection());
        }

        private void Tshirt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new addcart());
        }
    }
    }

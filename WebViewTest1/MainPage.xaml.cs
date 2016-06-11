using Xamarin.Forms;

namespace WebViewTest1
{
    public partial class MainPage : ContentPage
    {
        public MainPage ()
        {
            InitializeComponent ();

            gotoWebView.Clicked += GotoWebView_Clicked;
        }

        void GotoWebView_Clicked (object sender, System.EventArgs e)
        {
            App app = (App)Application.Current;
            Navigation.PushAsync (app.WebViewPage);
        }
    }
}


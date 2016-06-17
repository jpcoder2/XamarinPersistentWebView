using Xamarin.Forms;

namespace WebViewTest1
{
    public partial class App : Application
    {
        public WebViewPage WebViewPage;

        public App ()
        {
            InitializeComponent ();

            // setup WebViewPage
            this.WebViewPage = new WebViewPage ("https://www.google.com");

            var nav = new NavigationPage (new MainPage ());
            MainPage = nav;
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}


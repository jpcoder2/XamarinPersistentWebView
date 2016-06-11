using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WebViewTest1
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage (string url)
        {
            InitializeComponent ();

            Reset (url);
        }

        public void Reset (string url)
        {
            webView.Source = url;
        }
    }
}


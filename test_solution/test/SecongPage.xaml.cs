using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace test
{
    public partial class SecongPage : PhoneApplicationPage
    {
        public SecongPage()
        {
            InitializeComponent();
        }
        private void ShowInBrowser(string url)
        {
            Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            wbt.Uri = new Uri(url);
            wbt.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://www.bing.com");
        }
    }
}
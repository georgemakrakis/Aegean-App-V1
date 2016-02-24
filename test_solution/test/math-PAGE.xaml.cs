using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace aegeanapp
{
    public partial class math_PAGE : PhoneApplicationPage
    {
        public math_PAGE()
        {
            InitializeComponent();
        }
        private void ShowInBrowser(string url)
        {
            Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            wbt.Uri = new Uri(url);
            wbt.Show();
        }
        private async void LaunchPDF()
        {
            var installedLocation = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var assets = await installedLocation.GetFolderAsync("Assets");
            var pdf = await assets.GetFileAsync("math_Schedule.pdf");
            Windows.System.Launcher.LaunchFileAsync(pdf);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void search(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://www.google.com");
        }
    
        private void sef(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("http://myria.math.aegean.gr/sef/");

            URLs.url = "http://myria.math.aegean.gr/sef/";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void OPENeCLASS(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("https://eclass.aegean.gr/");

            URLs.url = "https://eclass.aegean.gr/";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void mail(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("https://webmail.aegean.gr/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.aegean.gr%2fowa"); 

            URLs.url = "https://webmail.aegean.gr/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.aegean.gr%2fowa";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void EUDOXUS_Click(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("http://eudoxus.gr/");

            URLs.url = "http://eudoxus.gr/";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void Academic_Calendar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Cal_MATH.xaml", UriKind.Relative));
        }

        private void math_MSc_Click(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("http://www.math.aegean.gr/pms/index.html");

            URLs.url = "http://www.math.aegean.gr/pms/index.html";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void schedule_icsd_Click(object sender, RoutedEventArgs e)
        {
            LaunchPDF();
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)/// main page math
        {
            //ShowInBrowser("https://www.math.aegean.gr/in/index.htm");

            URLs.url = "https://www.math.aegean.gr/in/index.htm";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }
    
    }
}
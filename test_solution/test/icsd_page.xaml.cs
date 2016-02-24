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
        private async void LaunchPDF()
        {
            var installedLocation = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var assets = await installedLocation.GetFolderAsync("Assets");
            var pdf = await assets.GetFileAsync("icsd_Schedule.pdf");
            Windows.System.Launcher.LaunchFileAsync(pdf);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://www.google.com");
        }


        private void eClass(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("https://eclass.icsd.aegean.gr/");

            URLs.url = "https://eclass.icsd.aegean.gr/";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void mail(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("https://webmail.aegean.gr/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.aegean.gr%2fowa");

            URLs.url = "https://webmail.aegean.gr/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.aegean.gr%2fowa";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void Icarus(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("https://icarus-icsd.aegean.gr/");

            URLs.url = "https://icarus-icsd.aegean.gr/";
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
            NavigationService.Navigate(new Uri("/Cal_ICSD.xaml", UriKind.Relative));
        }

        private void icsd_MSc_Click(object sender, RoutedEventArgs e)
        {
            //ShowInBrowser("http://msc.icsd.aegean.gr/");

            URLs.url = "http://msc.icsd.aegean.gr";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void schedule_icsd_Click(object sender, RoutedEventArgs e)
        {
            LaunchPDF();
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e) // main page mpes
        {
            //ShowInBrowser("https://www.icsd.aegean.gr/");

            URLs.url = "http://www.icsd.aegean.gr";
            NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }
    }





}

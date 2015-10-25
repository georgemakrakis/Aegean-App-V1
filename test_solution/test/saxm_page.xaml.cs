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
    public partial class saxm_page : PhoneApplicationPage
    {
        public saxm_page()
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
            var pdf = await assets.GetFileAsync("saxm_Schedule.pdf");
            Windows.System.Launcher.LaunchFileAsync(pdf);
        }
        private void OPENeCLASS(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://eclass.aegean.gr/");
        }

        private void Main_page_saxm(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://www.actuar.aegean.gr/");
        }

        private void search(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://www.google.com");
        }

        private void sef(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://www.samos.aegean.gr/st/");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void mail(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://webmail.aegean.gr/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.aegean.gr%2fowa"); 
        }

        private void EUDOXUS_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://eudoxus.gr/");
        }

        private void Academic_Calendar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Cal_SAXM.xaml", UriKind.Relative));
        }

        private void saxm_MSc_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://www.actuar.aegean.gr/postgraduate.html");
        }

        private void schedule_icsd_Click(object sender, RoutedEventArgs e)
        {
            LaunchPDF();
        }

       


        
    }
}
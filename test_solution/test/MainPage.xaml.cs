using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;
using aegeanapp.Resources;

namespace aegeanapp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        private void ShowInBrowser(string url)
        {
            Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            wbt.Uri = new Uri(url);
            wbt.Show();
        }
        private void Button_Click_to_ICSD(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/icsd_page.xaml", UriKind.Relative));
        }

        private void saxm_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/saxm_page.xaml", UriKind.Relative));
        }

        private void math_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/math-PAGE.xaml", UriKind.Relative));
        }

        private void Logo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ShowInBrowser("https://www.aegean.gr");
        }
        private void b_food1_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sitisi_MainPage.xaml", UriKind.Relative));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MapsPage.xaml", UriKind.Relative));
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask m=new MarketplaceReviewTask();
            m.Show();
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            EmailComposeTask et = new EmailComposeTask();
            et.Subject = "Aegean App - Feedback";
            et.To = "aegean_app@hotmail.com";
            et.Show();
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));

        }

       

  

       

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}
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
    public partial class Sittisi_MainPage : PhoneApplicationPage
    {   
        
        public Sittisi_MainPage()
        {
            InitializeComponent();

            Listpickername.Items.Add("1η Εβδομάδα");
            Listpickername.Items.Add("2η Εβδομάδα");
            Listpickername.Items.Add("3η Εβδομάδα");
            Listpickername.Items.Add("4η Εβδομάδα");

            Listpickername2.Items.Add("Μεσημεριανό");
            Listpickername2.Items.Add("Βραδινό");
        }

        private void OK_Button_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var choice1 = Listpickername.SelectedItem; //Getting value from the ListPicker
            var choice3 = Listpickername2.SelectedItem;
            string choice2 = (string)choice1;//Converting ListPickerValue to string
            string choice4 = (string)choice3;
            if (choice2.Equals("4η Εβδομάδα") && choice4.Equals("Μεσημεριανό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada4_Mesimeri.xaml", UriKind.Relative));
            }
            else if (choice2.Equals("3η Εβδομάδα") && choice4.Equals("Μεσημεριανό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada3_Mesimeri.xaml", UriKind.Relative));
            }
            else if (choice2.Equals("2η Εβδομάδα") && choice4.Equals("Μεσημεριανό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada2_Mesimeri.xaml", UriKind.Relative));
            }
            else if (choice2.Equals("1η Εβδομάδα") && choice4.Equals("Μεσημεριανό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada1_Mesimeri.xaml", UriKind.Relative));
            }
            else if (choice2.Equals("4η Εβδομάδα") && choice4.Equals("Βραδινό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada4_Bradi.xaml", UriKind.Relative));
            }
            else if (choice2.Equals("3η Εβδομάδα") && choice4.Equals("Βραδινό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada3_Bradi.xaml", UriKind.Relative));
            }
            else if (choice2.Equals("2η Εβδομάδα") && choice4.Equals("Βραδινό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada2_Bradi.xaml", UriKind.Relative));
            }
            else if (choice2.Equals("1η Εβδομάδα") && choice4.Equals("Βραδινό"))
            {
                NavigationService.Navigate(new Uri("/Ebdomada1_Bradi.xaml", UriKind.Relative));
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
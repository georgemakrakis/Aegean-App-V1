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
            //get_Week();
        }



        //public void get_Week()
        //{
        //    DateTime StartDate = new DateTime(2015, 11, 23);
        //    DateTime EndDate = DateTime.Today;
        //    double d_counter = (EndDate - StartDate).TotalDays;

        //    d_counter = d_counter / 7;
        //    if (d_counter >= 4)
        //    {
        //        d_counter = 0;
        //    }

        //    if (d_counter <= 1)
        //    {
        //        weekTbx.Text = "1η Εβδομάδα";

        //    }
        //    else if (d_counter <= 2)
        //    {
        //        weekTbx.Text = "2η Εβδομάδα";

        //    }
        //    else if (d_counter <= 3)
        //    {
        //        weekTbx.Text = "3η Εβδομάδα";

        //    }
        //    else if (d_counter <= 4)
        //    {
        //        weekTbx.Text = "4η Εβδομάδα";
        //    }
        //    else
        //    {
        //        weekTbx.Text = "No Εβδομάδα";
        //    }

        //}

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
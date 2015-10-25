using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

using Microsoft.Phone.Maps.Controls;
using System.Device.Location; // Provides the GeoCoordinate class.
using Windows.Devices.Geolocation;//Provides the Geocoordinate class.

using Windows.Storage.Streams;

using System.Windows.Media;
using System.Windows.Shapes;
namespace aegeanapp
{
    public partial class MapsPage : PhoneApplicationPage
    {


        private async void ShowMyLocationOnTheMap()
        {
            // Get my current location.
            Geolocator myGeolocator = new Geolocator();
            Geoposition myGeoposition = await myGeolocator.GetGeopositionAsync();
            Geocoordinate myGeocoordinate = myGeoposition.Coordinate;
            GeoCoordinate myGeoCoordinate = ShowMyLocationOnMap.CoordinateConverter.ConvertGeocoordinate(myGeocoordinate);


            this.maploc.Center = myGeoCoordinate;
            this.maploc.ZoomLevel = 13.8;



            // Create a small circle to mark the current location.
            Ellipse myCircle = new Ellipse();
            myCircle.Fill = new SolidColorBrush(System.Windows.Media.Colors.Red);
            myCircle.Height = 20;
            myCircle.Width = 20;
            myCircle.Opacity = 50;


            // Create a MapOverlay to contain the circle.
            MapOverlay myLocationOverlay = new MapOverlay();
            myLocationOverlay.Content = myCircle;
            myLocationOverlay.PositionOrigin = new Point(0.5, 0.5);
            myLocationOverlay.GeoCoordinate = myGeoCoordinate;


            // Create a MapLayer to contain the MapOverlay.
            MapLayer myLocationLayer = new MapLayer();
            myLocationLayer.Add(myLocationOverlay);

            // Add the MapLayer to the Map.
            maploc.Layers.Add(myLocationLayer);
        }
        private void AddMapIcon(Map map, GeoCoordinate geoPosition)
        {




            // Create a small circle to mark the current location.
            Ellipse myCircle = new Ellipse();
            myCircle.Fill = new SolidColorBrush(Colors.Blue);
            myCircle.Height = 20;
            myCircle.Width = 20;
            myCircle.Opacity = 50;


            // Create a MapOverlay to contain the circle.
            MapOverlay myLocationOverlay = new MapOverlay();
            myLocationOverlay.Content = myCircle;
            myLocationOverlay.PositionOrigin = new Point(0.5, 0.5);
            myLocationOverlay.GeoCoordinate = geoPosition;


            // Create a MapLayer to contain the MapOverlay.
            MapLayer myLocationLayer = new MapLayer();
            myLocationLayer.Add(myLocationOverlay);

            // Add the MapLayer to the Map.
            maploc.Layers.Add(myLocationLayer);
           
            
        }
        public MapsPage()
        {
            InitializeComponent();

            Listpicker.Items.Add("Κτίριο Εμπορικής Σχολής");
            Listpicker.Items.Add("Γραμματεία Τμήματος Μαθηματικών");
            Listpicker.Items.Add("Βιβλιοθήκη");
            Listpicker.Items.Add("Εργαστήριο Πολυμέσων");
            Listpicker.Items.Add("Κτίριο Λυμπέρη - Γραμματεία Τμήματος ΜΠΕΣ");
            Listpicker.Items.Add("Φοιτητική Λέσχη");
            Listpicker.Items.Add("Γραμματεία Τμήματος Στατιστικής");
            Listpicker.Items.Add("Κτίριο Προβατάρη");
            Listpicker.Items.Add("Νέο Σχολικό");
            Listpicker.Items.Add("Μεσαίο Σχολικό Συγκρότημα");
            Listpicker.Items.Add("Αίθουσα Δήμου");
            Listpicker.Items.Add("Κτήριο Παπανικολάου");
            Listpicker.Items.Add("Κτήριο Ψαθά");
            ShowMyLocationOnTheMap();
            
        }
        
        private void Locate_Btn_Click_1(object sender, RoutedEventArgs e)
        {
            ShowMyLocationOnTheMap();
        }

 

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            maploc.Layers.Clear();//clears map from previous pins
            var choice2 = (string)Listpicker.SelectedItem; //Getting value from the ListPicker
            ShowMyLocationOnTheMap();//relocates beacause it was removed in clearance
            if (choice2.Equals("Κτίριο Εμπορικής Σχολής"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.794894, 26.706629));
            }
            else if (choice2.Equals("Γραμματεία Τμήματος Μαθηματικών"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.790362, 26.705464));
            }
            else if (choice2.Equals("Βιβλιοθήκη"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.792066, 26.703158));
            }
           else if (choice2.Equals("Εργαστήριο Πολυμέσων"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.795572, 26.707423));
            }
            else if (choice2.Equals("Κτίριο Λυμπέρη - Γραμματεία Τμήματος ΜΠΕΣ"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.796000, 26.704939));
            }
            else if (choice2.Equals("Φοιτητική Λέσχη"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.790837, 26.697662));
            }
            else if (choice2.Equals("Γραμματεία Τμήματος Στατιστικής"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.794979,26.707900));
            }
            else if (choice2.Equals("Κτίριο Προβατάρη"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.794423, 26.684276));
            }
            else if(choice2.Equals("Αίθουσα Δήμου"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.791244, 26.704945));
            }
            else if (choice2.Equals("Νέο Σχολικό"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.795555, 26.706495));
            }
            else if (choice2.Equals("Μεσαίο Σχολικό Συγκρότημα"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.793974, 26.698884));
            }
            else if (choice2.Equals("Κτήριο Παπανικολάου"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.797204, 26.702308));
            }
            else if (choice2.Equals("Κτήριο Ψαθά"))
            {
                AddMapIcon(maploc, new GeoCoordinate(37.797518, 26.702684));
            }
        }

        private void Listpicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            okBtn_Click(null, null);
        }
        }
       

      
    }

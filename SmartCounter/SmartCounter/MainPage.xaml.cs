using SmartCounter.Models;
using SmartCounter.Views;
using System;
using Xamarin.Forms;

namespace SmartCounter
{
    public partial class MainPage : ContentPage
    {
        //Counter Model
        private Counter counter = new Counter();

        public MainPage()
        {
            InitializeComponent();

            //Elemets
            StackLayout stackLayout = new StackLayout();
            Frame boxView = new Frame { BackgroundColor = Color.Black};
            SwipeGestureRecognizer leftSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Left };
            TapGestureRecognizer tappedGesture = new TapGestureRecognizer();


            //Evenets
            leftSwipeGesture.Swiped += OnSwiped;
            tappedGesture.Tapped += OnTapped;

            stackLayout.GestureRecognizers.Add(leftSwipeGesture);
        }
        #region EVENTS
        private void OnTapped(object sender, EventArgs e)
        {
            counter.Count++;
            LabelCounter.Text = $"{counter.Count}";
        }
        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            counter.Count--;
            if (counter.Count < 0)
                counter.Count = 0;
            LabelCounter.Text = $"{counter.Count}";
        }
        private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
        {
            counter.Count = 0;
            LabelCounter.Text = $"{counter.Count}";
        }
        private void OnSettings_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Settings());
        }
        #endregion
    }
}

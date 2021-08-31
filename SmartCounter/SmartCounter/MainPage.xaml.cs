using SmartCounter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var boxView = new Frame { BackgroundColor = Color.Black};
            var leftSwipeGesture = new SwipeGestureRecognizer { Direction = SwipeDirection.Left };
            var tappedGesture = new TapGestureRecognizer();
            
           
            //Evenets
            leftSwipeGesture.Swiped += OnSwiped;
            tappedGesture.Tapped += OnTapped;

            boxView.GestureRecognizers.Add(leftSwipeGesture);
        }
        private void OnTapped(object sender, EventArgs e)
        {
            counter.Count++;
            LabelCounter.Text = $"{counter.Count}";
        }

        private void OnSwiped(object sender, SwipedEventArgs e)
        {
            counter.Count--;
            LabelCounter.Text = $"{counter.Count}";
        }
    }
}

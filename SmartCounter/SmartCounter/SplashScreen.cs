using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace SmartCounter
{
    public class SplashScreen : ContentPage
    {
        Image splashImage;

        public SplashScreen()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "smartcounter.jpeg",
                WidthRequest = 150,
                HeightRequest = 150
            };
            var lab = new Label();
            lab.Text = "By Yaccov Gigi";
            lab.FontSize = 35;
            
            lab.HorizontalTextAlignment = TextAlignment.Center;
            lab.VerticalTextAlignment = TextAlignment.Start;

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);
            sub.Children.Add(lab);
            

            this.BackgroundColor = Color.FromHex("#E69127");
            this.Content = sub;

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartCounter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {     
        StackLayout stackLayout = new StackLayout();
        public Settings()
        {
            InitializeComponent();
            stackLayout = (StackLayout)FindByName("SoundCounterIsVisible");
        }

        private void switch_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value)
            {
                stackLayout.IsVisible = true;
            }
            else
            {
                stackLayout.IsVisible = false;
            }
        }
        
        private void OnBackFromSettings_Click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
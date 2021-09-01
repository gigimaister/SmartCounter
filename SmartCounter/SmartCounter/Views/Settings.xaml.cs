using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SmartCounter.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {     
        StackLayout stackLayout = new StackLayout();
        Button SettingsButn = new Button();
        

        public Settings()
        {
            InitializeComponent();

            //Init IsSound && Num Of Count Per Sound Settings To Default
            SwitchSound.IsToggled = Preferences.Get("IsSoundToggle", false);
            EntryNumOfSoundClick.Text = Preferences.Get("NumOfCountPerSound", "10");

            //Bind To XAML Elements  
            stackLayout = (StackLayout)FindByName("SoundCounterIsVisible");
            SettingsButn = (Button)FindByName("SettingsBtn");

            stackLayout.IsVisible = SettingsButn.IsVisible = SwitchSound.IsToggled;
            SettingsButn.IsVisible = SwitchSound.IsToggled;

        }

        #region Events
        //Set Sound On
        private void switch_Toggled(object sender, ToggledEventArgs e)
        {
            if(e.Value)
            {
                stackLayout.IsVisible = true;
                SettingsButn.IsVisible = true;
            }
            else
            {
                stackLayout.IsVisible = false;
            }
        }
        //Back Btn
        private void OnBackFromSettings_Click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
        //SaveSetting Btn
        private void OnBtnSaveSettings_Clicked(object sender, EventArgs e)
        {
            
            Preferences.Set("IsSoundToggle", SwitchSound.IsToggled);
            Preferences.Set("NumOfCountPerSound", EntryNumOfSoundClick.Text);

            Application.Current.MainPage = new NavigationPage(new MainPage());

        }

        #endregion
    }
}
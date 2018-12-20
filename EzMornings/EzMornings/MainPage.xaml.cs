using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EzMornings
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Init();
        }

        class Constants
        {
            public static Color BackgroundColour = Color.FromRgb(15, 83, 193);
        }

        void Init()
       {
        BackgroundColor = Constants.BackgroundColour;
        }

        async void Buttn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Details());
        }

    }
}

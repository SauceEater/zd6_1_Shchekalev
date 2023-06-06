using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd4
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 :ContentPage
    {
        private Switch CheckBox;
        public Page1 (string username)
        {
            InitializeComponent( );
            
           
            Button button1 = new Button { Text = "STATIC", WidthRequest = 120, BorderRadius = 30, StyleId = "blue-button", Margin = new Thickness (10,0,5,0) };
           
            Button button2 = new Button { Text = "HOVER", WidthRequest = 120, BorderRadius = 30,StyleId = "blue-button", Margin = new Thickness(10, 0, 5, 0) };
           
            Button button3 = new Button { Text = "PRESSED", WidthRequest = 120, BorderRadius = 30, StyleId = "dark-blue-button", BorderColor = Color.Black, Margin = new Thickness(10, 0, 5, 0) };

            Button button4 = new Button { Text = "STATIC", WidthRequest = 120, BorderRadius = 30, StyleId = "gray-button", Margin = new Thickness (0,0,5,0) }; 

            Button button5 = new Button { Text = "HOVER", WidthRequest = 120, BorderRadius = 30, StyleId = "gray-button", Margin = new Thickness(0, 0, 5, 0) };

            Button button6 = new Button { Text = "PRESSED", WidthRequest = 120, BorderRadius = 30, StyleId = "dark-gray-button", Margin = new Thickness(0, 0, 5, 0) };

            Button button7 = new Button { Text = "STATIC", WidthRequest = 120, BorderRadius = 30, StyleId = "white-button" };

            Button button8 = new Button { Text = "HOVER", WidthRequest = 120, BorderRadius = 30, StyleId = "white-button" };

            Button button9 = new Button { Text = "PRESSED", WidthRequest = 120, BorderRadius = 30, StyleId = "white-button" };
            Slider slider1 = new Slider { Minimum = 0, Maximum = 100 };
            Slider slider2 = new Slider { Minimum = 0, Maximum = 100 };
            Slider slider3 = new Slider { Minimum = 0, Maximum = 100 };
            Slider slider4 = new Slider { Minimum = 0, Maximum = 100 };
            Switch sw1 = new Switch { };
            Switch sw2 = new Switch { };
            Switch sw3 = new Switch { };
            Switch sw4 = new Switch { };
            Switch sw5 = new Switch { };
            Switch sw6 = new Switch { };

            CheckBox = new Switch
            {
                BackgroundColor = Color.Gray,
                OnColor = Color.Gray,
                ThumbColor = Color.White
                
            };
            CheckBox.Toggled += (sender, e) =>
            {
                if (CheckBox.IsToggled)
                {
                    CheckBox.BackgroundColor = Color.Red;
                    CheckBox.ThumbColor = Color.White;
                    CheckBox.OnColor = Color.Red;
                }
                else
                {
                    CheckBox.BackgroundColor = Color.Gray;
                    CheckBox.ThumbColor = Color.White;
                    CheckBox.OnColor = Color.White;
                }
            };



            StackLayout buttonLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button1,button4,button7}
                
            };
            StackLayout buttonLayout2 = new StackLayout
            {
                
                Orientation = StackOrientation.Horizontal,
                Children = { button2,button5,button8}
            };
            StackLayout buttonLayout3 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { button3,button6,button9}
            };
            StackLayout sliderLayout = new StackLayout
            {
                Children = { slider1, slider2, slider3, slider4 }
            };
            StackLayout buttonLayout4 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = {sw1, sw4 }

            };
            StackLayout buttonLayout5 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { sw2, sw5 }
            };
            StackLayout buttonLayout6 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { sw3, sw6 }
            };

            StackLayout mainLayout = new StackLayout
            {
                Children = {buttonLayout, buttonLayout2, buttonLayout3,sliderLayout,buttonLayout4,buttonLayout5,buttonLayout6 }
            };

            Content = mainLayout;
        }


        private void picker_SelectedIndexChanged (object sender, EventArgs e)
        {
        }
    }
}   


   
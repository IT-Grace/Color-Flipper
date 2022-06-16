using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace color_flipper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            object[] colorcode = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F" }; 
            
            Random rnd = new Random();
            
            var newColor = "#";

            for(int i = 0; i < 6; i++)
            {
                int index = rnd.Next(colorcode.Length);
                newColor += colorcode[index];                
            }
                        
            colorname.Text = "color: " + newColor;
            
            frametext.TextColor = Color.FromHex(newColor);
            
            backdrop.BackgroundColor = Color.FromHex(newColor);
            
            btn.BackgroundColor = Color.FromHex(newColor);                        
        }
    }
}

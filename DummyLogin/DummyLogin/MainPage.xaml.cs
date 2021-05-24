using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DummyLogin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  void Button_ClickedAsync(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(email.Text);
            bool isPassowrdEmpty = string.IsNullOrEmpty(password.Text);

            if (isEmailEmpty || isPassowrdEmpty)
            {
                // Empty  so warning
                Console.Write("Empty");
            }
            else
            {
                Console.Write("Not Empty");


                // Go aheed Check id and password 
                 Navigation.PushAsync(new Page2());
            }
        }

        private void signup_Cliced(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());

        }
    }
}

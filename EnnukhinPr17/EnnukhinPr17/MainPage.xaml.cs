using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EnnukhinPr17
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonResult_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(entryNumber.Text, out int number))
            {
                using (var webClient = new WebClient())
                {
                    lableResult.TextColor = Color.Black;
                    lableResult.Text = webClient.DownloadString($"http://numbersapi.com/{number}");
                }
            }
            else
            {
                lableResult.TextColor = Color.Red;
                lableResult.Text = "Вы ввели не целое число!";
            }
        }
    }
}

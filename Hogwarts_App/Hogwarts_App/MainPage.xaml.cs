using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hogwarts_App
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void Button1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RunPage());
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Register_Page());
        }
    }
}

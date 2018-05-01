using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
//using Xamarin.Forms.Platform.UWP;
using Xamarin.Forms.Xaml;
using System.Globalization;
using Xamarin.Forms.PlatformConfiguration;

namespace Hogwarts_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slovenski : TabbedPage
    {
        private Timer timer = new Timer();
        int time;



        public Slovenski()
        {
            InitializeComponent();
            timer = new Timer();
        }
        private void Run(object sender, EventArgs e)
        {
            timer.Interval = 1;
            timer.Elapsed += Timer_count;
            timer.Enabled = true;
        }
        public void Timer_count(object sender, EventArgs e)
        {
            time++;
            //lblNumbers.Text = time.ToString();
        }
        private void Stop(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
        private void Gryffindor(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.Black)
            {
                this.BackgroundColor = Color.FromHex("7F0909");
            }
            else
            {
                this.BackgroundColor = Color.Black; ;
            }
        }

        private void Slytherin(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.Black)
            {
                this.BackgroundColor = Color.FromHex("0D6217");
            }
            else
            {
                this.BackgroundColor = Color.Black; ;
            }
        }
        private void Hufflepuff(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.Black)
            {
                this.BackgroundColor = Color.FromHex("FFC500");
            }
            else
            {
                this.BackgroundColor = Color.Black; ;
            }
        }

        private void Ravenclaw(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.Black)
            {
                this.BackgroundColor = Color.FromHex("000A90");
            }
            else
            {
                this.BackgroundColor = Color.Black; ;
            }
        }
        private void Language_Change(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RunPage());
        }

    }
}
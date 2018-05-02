﻿//using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
//using Org.W3c.Dom;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//using Android.App;
//using Android.Widget;
using System.Threading;
//using Java.Lang;

namespace Hogwarts_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Slovenski : TabbedPage
    {
        private System.Timers.Timer timer;
        int time;
        Label lblForTheTime;
        int min = 0;
        int seconds = 0;
        int miliseconds = 0;

        public Slovenski()
        {
            InitializeComponent();
            timer = new System.Timers.Timer();
            timer.AutoReset = true;
            lblForTheTime = this.FindByName<Label>("number_label");
        }
        private void Run(object sender, EventArgs e)
        {
            timer.Elapsed += Timer_count;
            timer.Enabled = true;
            timer.Start();
            timer.Interval = 1;
        }
        public void Timer_count(object sender, EventArgs e)
        {
            miliseconds++;
            if (miliseconds >= 1000)
            {
                seconds++;
                miliseconds = 0;
            }
            if (seconds >= 60)
            {
                min++;
                seconds = 0;
            }
            //Connects to label
            Device.BeginInvokeOnMainThread(() => { lblForTheTime.Text = min.ToString() + ":" + seconds.ToString() + ":" + miliseconds.ToString(); });
        }


        private void Stop(object sender, EventArgs e)
        {
            timer.Stop();

        }

        private void Reset(object sender, EventArgs e)
        {
            min = 0;
            seconds = 0;
            miliseconds = 0;
            Device.BeginInvokeOnMainThread(() => { lblForTheTime.Text = min.ToString() + ":" + seconds.ToString() + ":" + miliseconds.ToString(); });

        }
        private void Gryffindor(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.FromHex("7F0909"))
            {
                this.BackgroundColor = Color.Black;
            }
            else
            {
                this.BackgroundColor = Color.FromHex("7F0909");
            }
        }

        private void Slytherin(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.FromHex("0D6217"))
            {
                this.BackgroundColor = Color.Black;
            }
            else
            {
                this.BackgroundColor = Color.FromHex("0D6217");
            }
        }
        private void Hufflepuff(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.FromHex("FFC500"))
            {
                this.BackgroundColor = Color.Black;
            }
            else
            {
                this.BackgroundColor = Color.FromHex("FFC500");
            }
        }

        private void Ravenclaw(object sender, EventArgs e)
        {
            if (this.BackgroundColor == Color.FromHex("000A90"))
            {
                this.BackgroundColor = Color.Black;
            }
            else
            {
                this.BackgroundColor = Color.FromHex("000A90");
            }
        }
        private void Language_Change(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new RunPage());
        }
        private void Language_Change1(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Slovenski());
        }
    }
}

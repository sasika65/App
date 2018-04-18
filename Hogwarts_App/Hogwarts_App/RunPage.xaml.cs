using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Org.W3c.Dom;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hogwarts_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RunPage : TabbedPage
    {
        private Timer timer = new Timer();
        int time;
        

        public RunPage()
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
            lblNumbers.Text = time.ToString();
        }
        private void Stop(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
    }
}


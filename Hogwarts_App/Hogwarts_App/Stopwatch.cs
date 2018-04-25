using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace Hogwarts_App
{
    public class Stopwatch
    {
        static public void main()
        {
            //create stopwatch
            Stopwatch stopWatch = new Stopwatch();
            //Begin
           // stopWatch.Start();
            //do something
            for (int i = 0; i <1000; i++)
            {
                Thread.Sleep(1);
            }
            //stop
            //stopWatch.Stop();
            //write
            
            //lblForTheTime = RunPage.FindByName<Label>("number_label");
            
        }

    }
}

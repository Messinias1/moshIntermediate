﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moshIntermediate
{
    class Stopwatch
    {
        public static DateTime now = DateTime.Now;

        public void Start()
        { 
            Console.WriteLine("Hit Enter to start stopwatch: ");
            Console.ReadLine();
            
            String hourMinuteSec = now.ToString("HH:mm:ss");

            Console.WriteLine(hourMinuteSec);   
        }
        public void Stop()
        {
            Console.WriteLine("Hit Enter to stop stop watch: ");
            Console.ReadLine();

            DateTime now1 = DateTime.Now;
            TimeSpan diff = (now1 - now);
            var formattedDuration = String.Format(@"Elapsed Time : {0:hh\:mm\:ss\.ff}", diff.Duration());

            Console.WriteLine(formattedDuration);
        }
    }
}
//Design a class called Stopwatch.The job of this class is to simulate a stopwatch.It should provide two methods: Start and Stop.We call the start method ﬁrst, and the stop method next.Then we ask the stopwatch about the duration between start and stop. Duration should be a value in TimeSpan.Display the duration on the console. We should also be able to use a stopwatch multiple times.So we may start and stop it and then start and stop it again. Make sure the duration value each time is calculated properly. We should not be able to start a stopwatch twice in a row (because that may overwrite the initial start time). So the class should throw an InvalidOperationException if its started twice.

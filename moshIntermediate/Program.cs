using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace moshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                stopwatch.Stop();
                Stopwatch.now = DateTime.Now;
            };

        }
    }
}

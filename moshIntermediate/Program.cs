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
            // Simple Inheritance

            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}

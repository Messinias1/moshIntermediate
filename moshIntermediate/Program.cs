using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1994, 12, 6));
            Console.WriteLine(person.Age);
        }
    }
}

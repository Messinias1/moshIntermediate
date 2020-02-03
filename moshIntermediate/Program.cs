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
            Post post = new Post("CSharp Fundamentals", "Learn Csharp", DateTime.Now);
            Console.WriteLine(post._title + " " + post._description + " " + post._dayAndTime);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("Total Votes: " + post.DisplayVotes());
        }
    }
}

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
            // utilized getters
            Post post = new Post("CSharp Fundamentals", "Learn Csharp", DateTime.Now);
            Console.WriteLine(post.Title + " " + post.Description + " " + post.DayAndTime);
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("Total Votes: " + post.DisplayVotes());
        }
    }
}

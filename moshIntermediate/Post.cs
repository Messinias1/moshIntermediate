﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moshIntermediate
{
    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _dayAndTime;

        private int _vote = 0;

        public string Title { get { return _title; } }
        public string Description { get { return _description; } }
        public DateTime DayAndTime { get { return _dayAndTime; } }

        public Post(string aTitle, string aDescription, DateTime aDayAndTime)
        {
            _title = aTitle;
            _description = aDescription;
            _dayAndTime = aDayAndTime;
        }
        public int UpVote()
        {
            _vote++;
            return _vote;
        }
        public int DownVote()
        {
            if(_vote == 0)
            {
                return 0;
            }
             _vote--;
            return _vote;
        }
        public int DisplayVotes()
        {
            return this._vote;
        }
    }
}

// Design a class called Post. This class models a StackOverﬂow post. It should have properties for title, description and the date/time it was created. We should be able to up-vote or down-vote a post. We should also be able to see the current vote value. In the main method, create a post, up-vote and down-vote it a few times and then display the current vote value. 


// In this exercise, you will learn that a StackOverﬂow post should provide methods for up-voting and down-voting.You should not give the ability to set the Vote property from the outside, because otherwise, you may accidentally change the votes of a class to 0 or to a random number.And this is how we create bugs in our programs. The class should always protect its state and hide its implementation detail.

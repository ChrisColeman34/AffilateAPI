using APIConnector.Interfaces;
using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIConnector.APIs
{
    public interface IRedditAPI : IAPI
    {

    }
    public class RedditAPI : IRedditAPI
    {
        public void SetupConnection()
        {
            var reddit = new Reddit();
            reddit.InitOrUpdateUserAsync();
        }
    }
}

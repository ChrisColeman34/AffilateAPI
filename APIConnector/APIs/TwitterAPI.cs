using APIConnector.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Tweetinvi;

namespace APIConnector.APIs
{
    public interface ITwitterAPI : IAPI
    {

    }
    public class TwitterAPI : ITwitterAPI
    {
        public void SetupConnection()
        {
            Auth.SetUserCredentials("CONSUMER_KEY", "CONSUMER_SECRET", "ACCESS_TOKEN", "ACCESS_TOKEN_SECRET");
        }
    }
}

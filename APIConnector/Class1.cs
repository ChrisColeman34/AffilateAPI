using APIConnector.Interfaces;
using System;

namespace APIConnector
{
    public enum APIType
    {
        None = 0,
        TwitterSearch = 1,
        RedditSearch = 2,
        FacebookSearch = 3,
        AmazonAffiliate = 4,
        AwiinAffiliate = 5,
    }

    public interface IAPIFactory
    {
        IAPI Create(APIType type);
    }
    public class APIFactory : IAPIFactory
    {
        public IAPI Create(APIType type)
        {
            throw new NotImplementedException();
        }
    }
}

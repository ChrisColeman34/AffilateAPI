using System.Collections.Generic;

namespace AffiliateBuilder.Models
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }

        /// <summary>
        /// Description for smaller content display (content links, headers etc)
        /// </summary>
        string ShortDescription { get; set; }

        /// <summary>
        /// Holds the formatted html for the main body of content
        /// </summary>
        string ContentHTML { get; set; }

        /// <summary>
        /// Object to hold data about the product (Dimensions, image url, composition)
        /// </summary>
        IProductMetaData ProductMetaData { get; set; }

        /// <summary>
        /// ReviewMetaData holds comparison and rating information (quality of build, value for money etc)
        /// </summary>
        IEnumerable<IReviewMetaData> ReviewMetaData { get; set; }

        /// <summary>
        /// Holds the affiliate data (affiliate link, price, any extra information)
        /// </summary>
        IEnumerable<IAffiliate> Affiliates { get; set; }
    }
}

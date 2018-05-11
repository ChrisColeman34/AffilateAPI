using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffiliateBuilder.Models
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string ContentHTML { get; set; }
        public IProductMetaData ProductMetaData { get; set; }
        public IEnumerable<IReviewMetaData> ReviewMetaData { get; set; }
        public IEnumerable<IAffiliate> Affiliates { get; set; }
    }
}

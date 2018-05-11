using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffiliateBuilder.Models
{
    public class ProductMetaData : IProductMetaData
    {
        public int Id { get; set; }
        public string MetaDataHTML { get; set; }
        public string ImageURL { get; set; }
    }
}

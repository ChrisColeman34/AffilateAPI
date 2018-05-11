using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffiliateBuilder.Models
{
    public class Affiliate : IAffiliate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductURL { get; set; }
        public string AffiliateURL { get; set; }
        public int AffiliatePrice { get; set; }
    }
}

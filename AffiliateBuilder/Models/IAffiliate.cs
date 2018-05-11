using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffiliateBuilder.Models
{
    public interface IAffiliate
    {
        int Id { get; set; }
        string Name { get; set; }
        string ProductURL { get; set; }
        string AffiliateURL { get; set; }
        int AffiliatePrice { get; set; }
    }
}

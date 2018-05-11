using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffiliateBuilder.Models
{
    public interface IProductMetaData
    {
        int Id { get; set; }
        string MetaDataHTML { get; set; }
        string ImageURL { get; set; }
    }
}

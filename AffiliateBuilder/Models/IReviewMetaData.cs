using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffiliateBuilder.Models
{
    public interface IReviewMetaData
    {
        int Id { get; set; }
        IDictionary<string, int> ReviewFactors { get; set; }
        string ReviewHTML { get; set; }
        string ReviewURL { get; set; }
    }
}

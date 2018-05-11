using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AffiliateBuilder.Models
{
    public class ReviewMetaData : IReviewMetaData
    {
        public int Id { get; set; }
        public IDictionary<string, int> ReviewFactors { get; set; }
        public string ReviewHTML { get; set; }
        public string ReviewURL { get; set; }
    }
}

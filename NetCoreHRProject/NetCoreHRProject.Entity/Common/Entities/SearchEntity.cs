using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.Entity.Common.Entities
{
    [Serializable]
    public class SearchEntity<T> where T : new()
    {
        public SearchEntity()
        {
            Entity = new T();
        }

        public T Entity { get; set; }

        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public string Query { get; set; }

        public string DetailsArabic { get; set; }
        public string DetailsEnglish { get; set; }
        public int Status { get; set; }
        public string MessageArabic { get; set; }
        public string MessageEnglish { get; set; }
        public string CachingStatus { set; get; }
    }
}

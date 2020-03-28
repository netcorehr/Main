using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreHRProject.Entity.Common.Entities
{
    [Serializable]
    public class ResultEntity<T> where T : new()
    {
        public ResultEntity()
        {
            Entity = new T();
        }

        public T Entity { get; set; }

        public string DetailsArabic { get; set; }
        public string DetailsEnglish { get; set; }

        public int Status { get; set; }

        public string MessageArabic { get; set; }
        public string MessageEnglish { get; set; }
        public string CachingStatus { set; get; }

    }
}
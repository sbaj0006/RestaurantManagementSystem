using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderFoodSystem.Models
{
    public class PagingInfo
    {
        public int TotalItem { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int totalPage => (int)Math.Ceiling((decimal)TotalItem / ItemsPerPage);
        public string urlParam { get; set; }
    }
}

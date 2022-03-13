using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate.DTOs
{
    public class ShopDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string Location { get; set; }
        public int MaxDistance { get; set; }
        public int PriceRange { get; set; }
    }
}

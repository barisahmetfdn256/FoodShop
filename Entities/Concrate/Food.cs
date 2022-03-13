using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrate
{
    public class Food:IEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int UnitPrice { get; set; }
        public string Shop { get; set; }
    }
}

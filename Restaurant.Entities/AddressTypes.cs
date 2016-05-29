using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class AddressTypes : EntityBase
    {
        public int AddressTypeId { get; set; }
        public string Description { get; set; }
    }
}

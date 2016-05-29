using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class PhoneNumberTypes : EntityBase
    {
        public int PhoneNumberTypeId { get; set; }
        public string Description { get; set; }

    }
}

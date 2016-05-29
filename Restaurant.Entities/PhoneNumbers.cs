using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class PhoneNumbers : EntityBase
    {
        public int PhoneNumberId { get; set; }
        public string Number { get; set; }
        public virtual PhoneNumberTypes PhoneNumberTypes { get; set; }
        public virtual Branch Branch { get; set; }

    }
}

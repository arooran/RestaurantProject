using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class BranchAddress : EntityBase
    {
        public int BranchAddressId { get; set; }
        public Guid UniqueKey { get; set; }
        public string BuildingNumber { get; set; }       
        public string Town { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Country Country { get; set; }


    }
}

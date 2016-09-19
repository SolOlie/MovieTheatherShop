using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterShopDll.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public int ZipCode { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public int StreetNumber { get; set; }

    }
}

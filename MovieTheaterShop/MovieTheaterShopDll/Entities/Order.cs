using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterShopDll.Entities
{
    public class Order : AbstractEntity
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public List<Movie> Movies { get; set; }
    }
}

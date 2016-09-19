using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterShopDll.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }

    }
}

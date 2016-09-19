using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MovieTheaterShopDll.Entities;
using MovieTheaterShopDll.Managers;

namespace MovieTheaterShopDll
{
    public class DLLFacade 
    {
        public IManager<Genre> GetGenreManager()
        {
            return new GenreManager();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieShopAdmin.DAL
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base ("MovieContext")
        {
            
        }

        
    }
}
using MovieTheaterShopDll.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieShopAdmin.DAL
{
    public class MovieShopContext : DbContext
    {
        public MovieShopContext() : base()
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public Address Addresses { get; set; }





    }
}
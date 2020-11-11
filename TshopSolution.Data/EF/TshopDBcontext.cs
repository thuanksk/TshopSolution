using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TshopSolution.Data.Entites;

namespace TshopSolution.Data.EF
{
    public class TshopDBcontext : DbContext
    {
        public TshopDBcontext( DbContextOptions options) : base(options)
        {
           
        }


        public DbSet<Contact> Contacts { get; set; }

    }
}

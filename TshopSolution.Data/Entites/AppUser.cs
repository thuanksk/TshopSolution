﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace TshopSolution.Data.Entites
{
   public class AppUser:IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Order> Orders { get; set; }
        public List<TranSaction> TranSactions { get; set; }
    }
}

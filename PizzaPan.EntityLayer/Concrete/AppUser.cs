﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class AppUser: IdentityUser<int>
    {
     
        public string Name { get; set; }
        public string SurName { get; set; }
        public string  City { get; set; }

    }
}

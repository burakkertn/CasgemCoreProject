﻿using Microsoft.EntityFrameworkCore;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Concrete;
using Pizzapan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.DataAccessLayer.EntityFramework
{
    public class EnProductDal : GenericRepo<Product>, IProductDal
    {
        public List<Product> GetProductWithCategory()
        {
            using var context = new Context();
            return context.Products.Include(x => x.Category).ToList();  
        }
    }
}

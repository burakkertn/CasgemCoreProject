using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.DataAccessLayer.Repositories;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.DataAccessLayer.EntityFramework
{
    public class EnDiscountDal : GenericRepo<Discount>, IDiscountDal
    {
        public List<Discount> RandomWithKuopn()
        {
            throw new NotImplementedException();
        }
    }
}

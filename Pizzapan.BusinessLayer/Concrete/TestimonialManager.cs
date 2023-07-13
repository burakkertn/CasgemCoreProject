using Pizzapan.BusinessLayer.Abstact;
using Pizzapan.DataAccessLayer.Abstract;
using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class TestimonialManager  : ITestimonialService
    {
        private readonly ITestmonialDal _testmonialDal;

        public TestimonialManager(ITestmonialDal testmonialDal)
        {
            _testmonialDal = testmonialDal;
        }

        public void TDelete(Testimonial t)
        {
          _testmonialDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
          return _testmonialDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
           return _testmonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
           _testmonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
           _testmonialDal.Update(t);
        }
    }
}

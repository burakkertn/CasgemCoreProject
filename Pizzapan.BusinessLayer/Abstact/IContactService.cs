using PizzaPan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Abstact
{
    public interface IContactService : IGenericService<Contact>
    {
        List<Contact> TGetConnactBySubject();
    }
}

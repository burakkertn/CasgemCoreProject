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
    public class EnContactDal : GenericRepo<Contact>, IContactDal
    {
        public List<Contact> GetConnactBySubject()

        {
            using var context = new Context();
            var values = context.Contacts.Where(x => x.Subject == "Teşekkür").ToList();
            return values;

        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPan.EntityLayer.Concrete
{
    public class Discount
    {
        public int DiscountID { get; set; }
        public string DiscountCode { get; set; }

        public DateTime DiscountDate { get; set; }
        public DateTime DiscountLastDate { get; set; }
        public string DiscountSınır { get; set; }


    }
}

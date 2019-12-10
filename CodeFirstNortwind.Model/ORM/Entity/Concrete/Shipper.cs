using CodeFirstNortwind.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNortwind.Model.ORM.Entity.Concrete
{
    public class Shipper:BaseEntity
    {
        List<Order> Orders { get; set; }
        public string CompantyName { get; set; }
        public string Phone { get; set; }


    }
}

using CodeFirstNortwind.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNortwind.Model.ORM.Entity.Concrete
{
    public class OrderDetail:BaseEntity
    {
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
}

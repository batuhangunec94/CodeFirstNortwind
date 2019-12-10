using CodeFirstNortwind.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNortwind.Model.ORM.Entity.Concrete
{
    public class Product:BaseEntity
    {

        public string ProductName { get; set; }

        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        List<OrderDetail> orderDetails { get; set; }
        public double QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }


    }
}

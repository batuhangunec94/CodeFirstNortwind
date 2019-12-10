using CodeFirstNortwind.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNortwind.Model.ORM.Entity.Concrete
{
    public class Order:BaseEntity
    {
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeID { get; set; }
        public Employees Employees { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        List<OrderDetail> OrderDetails { get; set; }
        public int ShipperID { get; set; }
        public Shipper Shipper { get; set; }
        public string ShipVia { get; set; }
        public string Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }





    }
}

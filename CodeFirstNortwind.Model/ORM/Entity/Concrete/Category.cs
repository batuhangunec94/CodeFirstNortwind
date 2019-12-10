using CodeFirstNortwind.Model.ORM.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNortwind.Model.ORM.Entity.Concrete
{
    public class Category:BaseEntity
    {


        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        List<Product> Product { get; set; }

    }
}

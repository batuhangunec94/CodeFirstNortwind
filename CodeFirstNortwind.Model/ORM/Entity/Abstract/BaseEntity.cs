using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNortwind.Model.ORM.Entity.Abstract
{
    public enum Status
    {
        None = 0,
        Active = 1,
        Update = 2,
        Passive = 3
    }

    public class BaseEntity
    {
        
        public int ID { get; set; }
        private DateTime _addDate = DateTime.Now;
        public DateTime AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        private Status _status = Status.Active;
        public Status Status { get { return _status; } set { _status = value; } }




    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace org.company.order.entities
{
    public class Order : Aggregate
    {
        public Order()
        {
            this.OrderDetail = new HashSet<OrderDetail>();
        }

        public Order(int customerId, string orderNumber, int statusId)
        {
            this.OrderDetail = new HashSet<OrderDetail>();
            this.CustomerId = customerId;
            this.Number = orderNumber;
            this.StatusId = statusId;
            this.OrderDate = DateTime.Now;
            this.Active = true;
        }

        [Key]
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public string Number { get; private set; }

        public DateTime? OrderDate { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        
        public Status Status { get; set; }
        public Customer Customer { get; set; }

       
    }

   
}

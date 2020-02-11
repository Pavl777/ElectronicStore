using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ElectronicStore.Models.Catalog
{
    public class Order
    {
        [Key] 
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string TelNumber { get; set; }
        public bool IsCopleted { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }
       
    }
}
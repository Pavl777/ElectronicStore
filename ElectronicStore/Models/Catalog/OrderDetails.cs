 using ElectronicStore.Models.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ElectronicStore.Models.Catalog
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int ProductId { get; set; }//foreign key
        public int OrderId { get; set; }//foreign key
        public int Quantity { get; set; }
        [ForeignKey("ProductId") ]
        public virtual Product Product { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        
    }

}
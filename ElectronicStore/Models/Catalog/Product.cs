using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ElectronicStore.Models.Catalog
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int TypeId { get; set; }//freign key on type
        [ForeignKey("TypeId")]
        public virtual Catalog.Type Type { get; set; }
    }
    
}
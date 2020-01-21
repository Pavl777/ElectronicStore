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
        public bool IsCopleted { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Exam2.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [DisplayName("Supplier Id")]
        public int SupplierId { get; set; }
        [ForeignKey("Category")]
        [DisplayName("")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [DisplayName("Quantity Per Unit")]
        public int QuantityPerUnit { get; set; }
        [DisplayName("Unit In Stock")]
        public int UnitInStock { get; set; }
        [DisplayName("Unit On Order")]
        public int UnitOnOrder { get; set; }
        [DisplayName("Reoder Level")]
        public int ReorderLevel { get; set; }
        public double Discontinued { get; set; }
    }
}
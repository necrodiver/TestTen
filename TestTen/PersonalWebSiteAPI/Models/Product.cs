using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalWebSiteAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal ActualCost { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Customer { get; set; }

        // Navigation property
        // 导航属性
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        // Navigation properties
        // 导航属性
        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
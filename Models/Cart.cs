using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeorgianComputers.Models
{
    public partial class Cart
    {
        [Key]
        [StringLength(100)]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(100)]
        public string Username { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("Cart")]
        public virtual Product Product { get; set; }
    }
}

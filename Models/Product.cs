using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeorgianComputers.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        [Key]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(8000)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        [Range(0, 999999, ErrorMessage = "Price must be between 0 and 999,999")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        [StringLength(255)]
        public string Photo { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("Product")]
        public virtual Category Category { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<Cart> Cart { get; set; }
        [InverseProperty("Product")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}

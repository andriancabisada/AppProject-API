using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppProject.Models
{
    public partial class Product
    {
        public Product()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        [Key]
        [Column("ProductsID")]
        public int ProductsId { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string ProductName { get; set; } = null!;
        [Column("SKU")]
        [StringLength(100)]
        [Unicode(false)]
        public string? Sku { get; set; }
        [Column("CustomerSKU")]
        [StringLength(100)]
        [Unicode(false)]
        public string? CustomerSku { get; set; }
        [Column("ProductsTypeID")]
        public int ProductsTypeId { get; set; }
        [StringLength(5000)]
        [Unicode(false)]
        public string? ProductDesc { get; set; }
        public int CustomerCode { get; set; }
        [StringLength(4000)]
        [Unicode(false)]
        public string? CommentBox { get; set; }
        public int Status { get; set; }
        [Column("UOM")]
        public int? Uom { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string? PicPath { get; set; }
        public int? JewelryType { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }

        [InverseProperty(nameof(OrdersDetail.Products))]
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}

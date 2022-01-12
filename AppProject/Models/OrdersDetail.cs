using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppProject.Models
{
    public partial class OrdersDetail
    {
        [Key]
        [Column("OrdersDetailsID")]
        public int OrdersDetailsId { get; set; }
        [Column("OrdersID")]
        public int OrdersId { get; set; }
        [Column("ProductsID")]
        public int ProductsId { get; set; }
        [Column("ProductsInfoID")]
        public int? ProductsInfoId { get; set; }
        [Column("QTYOrdered")]
        public int Qtyordered { get; set; }
        [Column("QTYShipped")]
        public int Qtyshipped { get; set; }
        [Column("QTYInvoiced")]
        public int Qtyinvoiced { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EntryDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DueDate { get; set; }
        [Column("CustAdrsID")]
        public int CustAdrsId { get; set; }
        [StringLength(500)]
        [Unicode(false)]
        public string? Comment { get; set; }

        [ForeignKey(nameof(OrdersId))]
        [InverseProperty(nameof(Order.OrdersDetails))]
        public virtual Order Orders { get; set; } = null!;
        [ForeignKey(nameof(ProductsId))]
        [InverseProperty(nameof(Product.OrdersDetails))]
        public virtual Product Products { get; set; } = null!;
    }
}

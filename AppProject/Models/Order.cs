using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AppProject.Models
{
    public partial class Order
    {
        public Order()
        {
            OrdersDetails = new HashSet<OrdersDetail>();
        }

        [Key]
        [Column("OrdersID")]
        public int OrdersId { get; set; }
        [Column("POInternal")]
        [StringLength(100)]
        [Unicode(false)]
        public string Pointernal { get; set; } = null!;
        [Column("POExternal")]
        [StringLength(100)]
        [Unicode(false)]
        public string Poexternal { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ReceivedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime EntryDate { get; set; }
        [Column("CustomerID")]
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RequiredDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? TotalShippedDate { get; set; }
        [Column("OrderStatusID")]
        public int OrderStatusId { get; set; }
        [StringLength(200)]
        [Unicode(false)]
        public string? Comment { get; set; }

        [InverseProperty(nameof(OrdersDetail.Orders))]
        public virtual ICollection<OrdersDetail> OrdersDetails { get; set; }
    }
}

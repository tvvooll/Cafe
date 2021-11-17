using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeLab.Models
{
    [Table("orders")]
    public class Order
    {
        [Key]
        [Column("id", Order = 1)]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("address", Order = 2)]
        [StringLength(100)]
        [Required]
        [Display(Name = "Адреса доставки")]
        public string Address { get; set; }

        [Column("ordered_at", Order = 2)]
        [Required]
        [Display(Name = "Час замовлення")]
        public DateTime OrderedAt { get; set; }


        [Display(Name = "Страви")]
        public virtual ICollection<OrderDishes> Dishes { get; set; }
    }
}

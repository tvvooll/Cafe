using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeLab.Models
{
    [Table("OrderDishes")]
    [Display(Name = "Страви в замовленні")]
    public class OrderDishes
    {
        [Key]
        [Column("id", Order = 1)]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("dish_id", Order = 2)]
        [ForeignKey(nameof(Dish))]
        [Required]
        [Display(Name = "Страва")]
        public int DishId { get; set; }

        [Column("order_id", Order = 3)]
        [ForeignKey(nameof(Order))]
        [Required]
        [Display(Name = "Замовлення")]
        public int OrderId { get; set; }


        [Display(Name = "Страва")]
        public virtual Dish Dish { get; set; }

        [Display(Name = "Замовлення")]
        public virtual Order Order { get; set; }
    }
}

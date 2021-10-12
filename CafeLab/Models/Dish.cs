using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeLab.Models
{
    [Table("dishes")]
    [Display(Name = "Страва")]
    public class Dish
    {
        [Key]
        [Column("id", Order = 1)]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("name", Order = 2)]
        [StringLength(50)]
        [Required]
        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Column("price", Order = 3)]
        [Range(0, int.MaxValue)]
        [Required]
        [Display(Name = "Ціна")]
        public int Price { get; set; }

        [Column("weight", Order = 4)]
        [Range(0, int.MaxValue)]
        [Required]
        [Display(Name = "Маса")]
        public int Weight { get; set; }

        [Column("description", Order = 5)]
        [StringLength(50)]
        [Display(Name = "Опис")]
        public string Description { get; set; }

        [Column("picture_url", Order = 6)]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Картинка")]
        public string PictureUrl { get; set; }

        [Column("category_id", Order = 7)]
        [ForeignKey(nameof(Category))]
        [Required]
        [Display(Name = "Категорія")]
        public int CategoryId { get; set; }


        [Display(Name = "Категорія")]
        public virtual Category Category { get; set; }

        [Display(Name = "Замовлення")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}

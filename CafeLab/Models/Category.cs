using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CafeLab.Models
{
    [Table("categories")]
    [Display(Name = "Категорія")]
    public class Category
    {
        [Key]
        [Column("id" ,Order = 1)]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Column("name", Order = 2)]
        [StringLength(50)]
        [Required]
        [Display(Name = "Назва")]
        public string Name { get; set; }

        [Column("description", Order = 3)]
        [StringLength(50)]
        [Display(Name = "Опис")]
        public string Description { get; set; }



        [Display(Name = "Страви")]
        public virtual ICollection<Dish> Dishes { get; set; }
    }
}

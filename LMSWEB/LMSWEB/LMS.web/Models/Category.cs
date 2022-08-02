using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMS.web.Models
{
    [Table(name:"Cateogaries")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [Column(TypeName ="varchar(50)")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

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
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName ="varchar(50)")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}

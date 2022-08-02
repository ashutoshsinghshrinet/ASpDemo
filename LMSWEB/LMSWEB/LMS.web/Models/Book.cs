using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMS.web.Models
{
    [Table(name:"Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookId { get; set; }

        [Required]
        [StringLength(100)]
        public string BookTitle { get; set; }

        [Required]
        [DefaultValue(1)]
        public int NumberOfCopies { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsEnabled { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey(nameof(Book.CategoryId))]
        public Category Category { get; set; }
    }
}

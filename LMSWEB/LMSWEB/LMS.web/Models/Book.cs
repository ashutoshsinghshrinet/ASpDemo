using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMS.web.Models
{
    [Table(name: "Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Book ID")]
        public int bookId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name ="Book Name")]
        public string BookTitle { get; set; }

        [Required]
        [DefaultValue(1)]
        [Display(Name = "Number of Copies")]
        public int NumberOfCopies { get; set; }

        [Required]
        [DefaultValue(false)]
        [Display(Name = "Is it Enabled ?")]
        public bool IsEnabled { get; set; }

        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(Book.CategoryId))]
        public Category Category { get; set; }
    }
}

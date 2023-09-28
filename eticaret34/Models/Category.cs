using System.ComponentModel.DataAnnotations;

namespace eticaret34.Models
{
    public class Category
    {
        [Key]
        [Display(Name ="Kategori Id")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Kategori Adını Boş Bıramazsınız")]
        [Display(Name = "Kategori Adı")]
        public string? CategoryName { get; set; }

        virtual public ICollection<Product>? Products { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticaret34.Models
{
    public class Product
    {
        [Key]
        [Display(Name ="Ürün Id")]
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Bu Alanı Boş Bırakamazsınız")]  
        [Display(Name = "Ürün Adı")]
        public string? ProductName { get; set; }
        [Required(ErrorMessage = "Bu Alanı Boş Bırakamazsınız")]
        [Display(Name = "Ürün Kodu")]
        public string? ProductCode { get; set; }
        [Required(ErrorMessage = "Bu Alanı Boş Bırakamazsınız")]
        [Display(Name = "Ürün Fiyatı")]
        public int? ProductPrice { get; set; }
        [Required(ErrorMessage = "Bu Alanı Boş Bırakamazsınız")]
        [Display(Name = "Ürün Açıklaması")]
        public string? ProductDescription { get; set; }
        [Required(ErrorMessage = "Bu Alanı Boş Bırakamazsınız")]
        [Display(Name = "Ürün Resmi")]
        public string?  ProductPicture { get; set; }
        [Required(ErrorMessage = "Bu Alanı Boş Bırakamazsınız")]
        [Display(Name = "Ürün Kategorisi")]
        [NotMapped]
        public IFormFile? ResimYukle { get; set; }

        public int CategoryId { get; set; }
        virtual public  Category? Category { get; set; }
       

    }
}

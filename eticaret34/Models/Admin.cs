using System.ComponentModel.DataAnnotations;

namespace eticaret34.Models
{
    public class Admin
    {
        [Key]
        [Display(Name ="Admin Id")]
        public int AdminId { get; set; }
        [Display(Name = "Admin Adı")]
        public  string users { get; set; }
        [Display(Name = "Admin Şifresi")]
        public string pass { get; set; }
    }
}

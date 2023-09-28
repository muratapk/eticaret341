using Microsoft.AspNetCore.Identity;

namespace eticaret34.Models
{
    public class AppUser:IdentityUser<int>
    {
        public   string  FirstName { get; set; }=string.Empty;
        public string LastName { get; set; } = string.Empty;

        public int ConfirmCode { get; set; }    

    }
}

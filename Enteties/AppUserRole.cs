using Microsoft.AspNetCore.Identity;

namespace API.Enteties
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public AppUser User { get; set; } = null!;
        public AppRole Role { get; set; } = null!;
        
    }
}
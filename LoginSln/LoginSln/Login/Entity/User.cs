using Microsoft.AspNetCore.Identity;

namespace Login.Entity
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }            


    }
}

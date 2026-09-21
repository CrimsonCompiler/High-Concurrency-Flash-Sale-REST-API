using Microsoft.AspNetCore.Identity;

namespace FlashSale.Api.Models;

public class AppUser: IdentityUser
{
    public string FullName  { get; set; } = string.Empty;
    public string Role { get; set; } = "Customer";
}
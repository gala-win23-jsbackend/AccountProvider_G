

namespace AccountProvider_G.Models;

public class UserRegistrationRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}

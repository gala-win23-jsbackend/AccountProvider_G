

namespace AccountProvider_G.Models;

public class VerificationRequest
{
    public string Email { get; set; } = null!;
    public string VerificationCode { get; set; } = null!;
}

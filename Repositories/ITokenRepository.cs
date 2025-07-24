using Microsoft.AspNetCore.Identity;

namespace GreatWalks.API.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}

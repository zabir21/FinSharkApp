using api.Models;

namespace api.Interfaces
{
    public interface ITokenService
    {
        string CreteToken(AppUser user);
    }
}
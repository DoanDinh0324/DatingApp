using API.Entities;

namespace API.Interfaes
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
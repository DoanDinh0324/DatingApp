using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaes
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);



    }
}
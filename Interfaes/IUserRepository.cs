using API.DTOs;
using API.Entities;
using Microsoft.AspNetCore.Mvc;


namespace API.Interfaes
{
    public interface IUserRepository
    {
        void Update(AppUser user);

        Task<bool> SaveAllAsync();

        Task<IEnumerable<AppUser>> GetUsersAsync();

        Task<AppUser> GetUserByIdAsync(int id);

        Task<ActionResult<AppUser>> GetUserByUsernameAsync(string username);

        Task<IEnumerable<MemberDto>> GetMembersDtos();

        Task<MemberDto> GetMembersAsync(string username);
        
        Task<ActionResult<MemberDto>> GetMemberAsync(string username);

    }
}
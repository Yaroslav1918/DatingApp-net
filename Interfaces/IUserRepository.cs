using API.DTOs;
using API.Enteties;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser?> GetUserByIdAsync(int id);
        Task<AppUser?> GetUserByUserNameAsync(string userName);
        Task<MemberDto?> GetMemberAsync(string username);

        Task<IEnumerable<MemberDto>> GetMembersAsync();
    }
}
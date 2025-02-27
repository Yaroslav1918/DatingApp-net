using API.DTOs;
using API.Enteties;
using API.Helpers;

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

        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
    }
}
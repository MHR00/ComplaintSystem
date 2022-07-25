using ComplaintSystem.Model.Models;

namespace ComplaintSystem.Logic.Services
{
    public interface IUserService
    {
        Task DeleteUser(int id);
        Task<UserModel?> GetUser(int id);
        Task<IEnumerable<UserModel>> GetUsers();
        Task InsertUser(UserModel user);
        Task UpdateUser(UserModel user);
    }
}
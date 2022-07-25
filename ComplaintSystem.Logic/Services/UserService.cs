using ComplaintSystem.Logic.DataAccess;
using ComplaintSystem.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly ISqlDataAccess _db;
        public UserService(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers() =>
            _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });

        public async Task<UserModel?> GetUser(int id)
        {
            var result = await _db.LoadData<UserModel, dynamic>("dbo.spUser_Get", new { Id = id });
            return result.FirstOrDefault();
        }

        public Task InsertUser(UserModel user) =>
            _db.SaveData("dbo.spUser_insert", new { user.UserName, user.Email, user.Password, user.Role });
        public Task UpdateUser(UserModel user) =>
            _db.SaveData("dbo.spUser_Update", user);
        
        public Task DeleteUser(int id) =>
            _db.SaveData("dbo.spUser_Delete", new { Id = id });
    }
}

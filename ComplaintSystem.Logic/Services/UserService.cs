using ComplaintSystem.Logic.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplaintSystem.Logic.Services
{
    public class UserService
    {
        private readonly ISqlDataAccess _db;
        public UserService(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers() =>
            _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });
    }
}

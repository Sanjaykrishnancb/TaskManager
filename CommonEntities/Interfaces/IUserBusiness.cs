using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonEntities.Interfaces
{
    public interface IUserBusiness
    {
        bool AddUser(UsersModel user);
        List<UsersModel> GetUsers();

        bool DeleteUser(UsersModel user);
    }
}

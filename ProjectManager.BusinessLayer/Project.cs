using CommonEntities;
using ProjectManager.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.BusinessLayer
{
    public class Project
    {
        public Project()
        {

        }

        public bool AddUser(UsersModel user)
        {
            using (ProjectManagerEntities dbContext = new ProjectManagerEntities())
            {
                Users_Table userData = new Users_Table()
                {
                    Employee_ID = user.Employee_ID,
                    First_Name = user.First_Name,
                    Last_Name = user.Last_Name
                };
                try
                {
                    dbContext.Users_Table.Add(userData);
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }

        }

        public List<UsersModel> GetUsers()
        {
            using (ProjectManagerEntities dbContext = new ProjectManagerEntities())
            {
                List<UsersModel> users;
                try
                {
                    users = dbContext.Users_Table.Select(c=>new UsersModel { User_ID=c.User_ID, First_Name=c.First_Name,Last_Name=c.Last_Name,Employee_ID=c.Employee_ID }).ToList();
                }
                catch (Exception e)
                {
                    return new List<UsersModel>();
                }
                return users;
            }

        }
    }
}

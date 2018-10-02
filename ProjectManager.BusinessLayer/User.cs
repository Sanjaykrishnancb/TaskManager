using CommonEntities;
using CommonEntities.Interfaces;
using ProjectManager.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.BusinessLayer
{
    public class User: IUserBusiness
    {
        private readonly ProjectManagerEntities dbContext = null;
        public User()
        {
            dbContext = new ProjectManagerEntities();
        }

        public User(ProjectManagerEntities dbContextData)
        {
            dbContext = dbContextData;
        }

        public bool AddUser(UsersModel user)
        {
            //using (ProjectManagerEntities dbContext = new ProjectManagerEntities())
            //{
                try
                {
                    if (user.User_ID == 0)
                    {
                        Users_Table userData = new Users_Table()
                        {
                            Employee_ID = user.Employee_ID,
                            First_Name = user.First_Name,
                            Last_Name = user.Last_Name
                        };

                        dbContext.Users_Table.Add(userData);
                        dbContext.SaveChanges();
                    }
                    else
                    {
                        var userData = dbContext.Users_Table.Where(c => c.User_ID == user.User_ID).First();
                        if (userData != null)
                        {
                            userData.First_Name = user.First_Name;
                            userData.Last_Name = user.Last_Name;
                            userData.Employee_ID = user.Employee_ID;
                            dbContext.SaveChanges();
                        }
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
           // }

        }

        public List<UsersModel> GetUsers()
        {
            //using (ProjectManagerEntities dbContext = new ProjectManagerEntities())
            //{
                List<UsersModel> users;
                try
                {
                    users = dbContext.Users_Table.Select(c => new UsersModel { User_ID = c.User_ID, First_Name = c.First_Name, Last_Name = c.Last_Name, Employee_ID = c.Employee_ID }).ToList();
                }
                catch (Exception e)
                {
                    return new List<UsersModel>();
                }
                return users;
            //}

        }

        public bool DeleteUser(UsersModel user)
        {
            //using (ProjectManagerEntities dbContext = new ProjectManagerEntities())
            //{
                try
                {
                    var userData = new Users_Table { User_ID = user.User_ID };
                    dbContext.Entry(userData).State = EntityState.Deleted;
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
            
        //}
    }
}

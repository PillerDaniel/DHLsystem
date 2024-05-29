using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DhlSystem.Model;

namespace DhlSystem.Repository
{
    class UserRepository
    {
        private DhlSystemContext dhlContext;

        public UserRepository (DhlSystemContext dhlContext)
        {
            this.dhlContext = dhlContext;
        }

        public List<User> GetUsers()
        {
            return dhlContext.Users.ToList();
        }
        public User GetUserByUsername(string username) 
        {
            return dhlContext.Users.Find(username);
        }
        public User GetUserById(int id)
        {
            return dhlContext.Users.Find(id);
        }
        public void InsertUser(User user)
        {
            dhlContext.Users.Add(user);
        }
        public void DeleteUser(int id)
        {
            dhlContext.Users.Remove(dhlContext.Users.Find(id));
        }
        public  void UpdateUser(User user) 
        {
            dhlContext.Users.Find(user.Id).UserName = user.UserName;
            dhlContext.Users.Find(user.Id).Password = user.Password;
            dhlContext.Users.Find(user.Id).permission = user.permission;
        }
        public void Save()
        {
            dhlContext.SaveChanges();
        }
        public void Dispose()
        {
            dhlContext.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

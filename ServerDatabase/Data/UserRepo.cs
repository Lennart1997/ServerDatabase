using System;
using System.Linq;
using System.Threading.Tasks;

namespace RestServer.Data
{
    
    public class UserRepo : IUserRepo
    {
        
        private DBContext ctx;

        public UserRepo(DBContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<User> ValidateUser(string username, string password)
        {
            User first = ctx.User.FirstOrDefault(user => user.username.Equals(username));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
        
    }
    
}
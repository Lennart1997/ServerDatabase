using System.Threading.Tasks;

namespace RestServer.Data
{
    public interface IUserRepo 
    {
        Task<User> ValidateUser(string username, string password);

    }
}
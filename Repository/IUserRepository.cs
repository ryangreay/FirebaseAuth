using System.Threading.Tasks;

namespace Firebase.Auth.Repository
{
    /// <summary>
    /// Repository abstraction for <see cref="User"/>.
    /// </summary>
    public interface IUserRepository
    {
        Task<bool> UserExists();

        Task<(UserInfo userInfo, FirebaseCredential credential)> ReadUser();

        Task SaveUser(User user);

        Task DeleteUser();
    }
}

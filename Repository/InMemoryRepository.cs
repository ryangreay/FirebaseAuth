using System;
using System.Threading.Tasks;

namespace Firebase.Auth.Repository
{
    /// <inherit />
    public class InMemoryRepository : IUserRepository
    {
        private static InMemoryRepository instance;

        private User user;

        private InMemoryRepository()
        {
        }

        public static InMemoryRepository Instance => instance ?? (instance = new InMemoryRepository());

        public async Task<bool> UserExists()
        {
            return this.user != null;
        }

        public async Task<(UserInfo, FirebaseCredential)> ReadUser()
        {
            return (this.user?.Info, this.user?.Credential);
        }

        public async Task SaveUser(User user)
        {
            this.user = user;
        }

        public async Task DeleteUser()
        {
            this.user = null;
        }
    }
}

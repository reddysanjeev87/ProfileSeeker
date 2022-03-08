using System.Threading.Tasks;

namespace ProfileSeeker.Application
{
    public interface IUserProfileSeeker
    {
        /// <summary>
        /// this take username as input
        /// and fetch the user information from github
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<UserProfileViewModel> Get(string userName);
    }
}

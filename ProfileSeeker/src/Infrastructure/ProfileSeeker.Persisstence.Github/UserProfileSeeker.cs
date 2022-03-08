using ProfileSeeker.Application;
using System.Threading.Tasks;

namespace ProfileSeeker.Persisstence.Github
{
    /// <summary>
    /// Members are explicitly implemented
    /// so that only interface members are public
    /// and class members are private
    /// </summary>
    public class UserProfileSeeker : IUserProfileSeeker
    {
        private readonly IHttpClientProxy httpClientProxy;
        private readonly IJsonConverter jsonConverter;
        private readonly IProfileSeekerConfiguration profileSeekerConfiguration;
        private readonly IUserRepositorySeeker userRepositorySeeker;
        public UserProfileSeeker(IHttpClientProxy httpClientProxy
            , IJsonConverter jsonConverter, IProfileSeekerConfiguration profileSeekerConfiguration
            , IUserRepositorySeeker userRepositorySeeker)
        {
            this.httpClientProxy = httpClientProxy;
            this.jsonConverter = jsonConverter;
            this.profileSeekerConfiguration = profileSeekerConfiguration;
            this.userRepositorySeeker = userRepositorySeeker;
        }

        async Task<UserProfileViewModel> IUserProfileSeeker.Get(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {
                return new UserProfileViewModel { Message = "User Name should not be empty" };
            }
            UserProfileViewModel userProfile = null;
            var gitubUrl = this.profileSeekerConfiguration.GetGithubUrl() + userName;

            using (var client = this.httpClientProxy.GetHttpClient(gitubUrl))
            {
                var response = await client.GetAsync(gitubUrl);
                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    userProfile = this.jsonConverter.Deserialize<UserProfileViewModel>(data);
                    userProfile.HttpStatus = response.StatusCode;
                }
            }
            if (userProfile == null)
            {
                return new UserProfileViewModel { IsValid=false,
                    Message = "User does not exists in the github" };
            }
            if (string.IsNullOrWhiteSpace(userProfile.repos_url))
            {
                userProfile.IsValid = false;
                userProfile.Message = "This user does not have any repository in the github";
                return userProfile;
            }

            userProfile.repos = await this.userRepositorySeeker.GetAllByUrl(userProfile.repos_url);
            return userProfile;
        }
    }
}

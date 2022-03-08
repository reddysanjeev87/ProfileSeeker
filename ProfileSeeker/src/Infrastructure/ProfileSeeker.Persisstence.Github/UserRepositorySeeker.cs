using ProfileSeeker.Application;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileSeeker.Persisstence.Github
{
    /// <summary>
    /// Members are explicitly implemented
    /// so that only interface members are public
    /// and class members are private
    /// </summary>
    public class UserRepositorySeeker : IUserRepositorySeeker
    {
        private readonly IHttpClientProxy httpClientProxy;
        private readonly IJsonConverter jsonConverter;
        public UserRepositorySeeker(IHttpClientProxy httpClientProxy
            , IJsonConverter jsonConverter)
        {
            this.httpClientProxy = httpClientProxy;
            this.jsonConverter = jsonConverter;
        }
        /// <summary>
        /// This will read the repository information of any specific git user
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        async Task<List<UserRepositoryViewModel>> IUserRepositorySeeker.GetAllByUrl(string url)
        {
            List<UserRepositoryViewModel> userRepositories = null;
            using (var httpClient = this.httpClientProxy.GetHttpClient(url))
            {
                var responseRepo = await httpClient.GetAsync(url);
                if (responseRepo.IsSuccessStatusCode)
                {
                    var data = await responseRepo.Content.ReadAsStringAsync();
                    userRepositories = this.jsonConverter.Deserialize<List<UserRepositoryViewModel>>(data);
                    if (userRepositories != null && userRepositories.Count > 0)
                    {
                        userRepositories = userRepositories.OrderByDescending(x => x.stargazers_count).Take(5).ToList();
                    }
                }
            }
            return userRepositories;
        }
    }
}


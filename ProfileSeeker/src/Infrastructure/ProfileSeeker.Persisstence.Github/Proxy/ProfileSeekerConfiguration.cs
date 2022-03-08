using ProfileSeeker.Application;
using System.Configuration;

namespace ProfileSeeker.Persisstence.Github
{
    /// <summary>
    /// Members are explicitly implemented
    /// so that only interface members are public
    /// and class members are private
    /// </summary>
    public class ProfileSeekerConfiguration : IProfileSeekerConfiguration
    {
        string IProfileSeekerConfiguration.GetGithubUrl()
        {
            return ConfigurationManager.AppSettings["GithubUrl"];
        }
    }
}

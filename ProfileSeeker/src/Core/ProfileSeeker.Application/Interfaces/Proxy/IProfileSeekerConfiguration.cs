namespace ProfileSeeker.Application
{
    /// <summary>
    /// this interface is responsible for reading configuration
    /// data
    /// </summary>
    public interface IProfileSeekerConfiguration
    {
        /// <summary>
        /// this read github url from web.config file
        /// </summary>
        /// <returns></returns>
        string GetGithubUrl(); 
    }
}

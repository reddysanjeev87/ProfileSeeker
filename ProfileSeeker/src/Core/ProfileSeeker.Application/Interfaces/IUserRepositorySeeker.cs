using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProfileSeeker.Application
{
    public interface IUserRepositorySeeker
    {
        Task<List<UserRepositoryViewModel>> GetAllByUrl(string url);
    }
}

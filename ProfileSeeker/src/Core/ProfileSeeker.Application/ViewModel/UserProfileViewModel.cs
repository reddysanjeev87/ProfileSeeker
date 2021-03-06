using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileSeeker.Application
{
    public class UserProfileViewModel:BaseViewModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public string avatar_url { get; set; }
        public string repos_url { get; set; }
        public List<UserRepositoryViewModel> repos { get; set; }
    }
}

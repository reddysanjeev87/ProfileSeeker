using System.Net;

namespace ProfileSeeker.Application
{
    public class BaseViewModel
    {
        public BaseViewModel()
        {
            this.IsValid = true;
        }
        public HttpStatusCode HttpStatus { get; set; }
        public string Message { get; set; }
        public bool IsValid { get; set; }
    }
}

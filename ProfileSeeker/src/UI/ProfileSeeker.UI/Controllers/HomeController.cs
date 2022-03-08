using ProfileSeeker.Application;
using ProfileSeeker.UI.Models;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ProfileSeeker.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserProfileSeeker userProfileSeeker;
        public HomeController(IUserProfileSeeker userProfileSeeker)
        {
            this.userProfileSeeker = userProfileSeeker;
        }

        public ActionResult Index()
        {
            return View(new UserProfileViewModel());
        }
        [HttpPost]
        public async Task<ActionResult> Index(string username)
        {
            var user = new UserProfileViewModel();
            try
            {
                user=await this.userProfileSeeker.Get(username);
            }
            catch (Exception exp)
            {
                return RedirectToAction("Error");
            }

            return View("Index", user);
        }


        public ActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = "curent requestid" });
        }
    }
}
namespace MyForumSystem.Web.Controllers
{
    using System.Web.Mvc;

    using MyForumSystem.Data.Common.Repository;
    using MyForumSystem.Data.Models;
    using Data;
    public class HomeController : Controller
    {
        private IRepository<Post> posts;

        //Poor man's DI
        public HomeController()
            : this(new GenericRepository<Post>(new ApplicationDbContext()))
        {
        }

        public HomeController(IRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            var model = this.posts.All();

            return this.View(model);
        }
    }
}
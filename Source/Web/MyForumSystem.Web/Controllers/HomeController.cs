namespace MyForumSystem.Web.Controllers
{
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using MyForumSystem.Data.Common.Repository;
    using MyForumSystem.Data.Models;
    using Data;
    using ViewModels;
    public class HomeController : Controller
    {
        private IRepository<Post> posts;

        public HomeController(IRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            var model = this.posts.All().ProjectTo<IndexBlogPostViewModel>();

            return this.View(model);
        }
    }
}
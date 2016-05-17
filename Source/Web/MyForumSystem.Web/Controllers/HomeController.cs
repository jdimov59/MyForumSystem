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
        private IDeletableEntityRepository<Post> posts;

        public HomeController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        public ActionResult Index()
        {
            //this.posts.Delete(12);
            //this.posts.ActualDelete(this.posts.GetById(8));
            //this.posts.SaveChanges();
            var model = this.posts.All().ProjectTo<IndexBlogPostViewModel>();

            return this.View(model);
        }
    }
}
using MyForumSystem.Data.Common.Repository;
using MyForumSystem.Data.Models;
using MyForumSystem.Web.InputModels.Questions;
using System.Web.Mvc;

namespace MyForumSystem.Web.Controllers
{
    public class QuestionsController : Controller
    {
        private IDeletableEntityRepository<Post> posts;

        public QuestionsController(IDeletableEntityRepository<Post> posts)
        {
            this.posts = posts;
        }

        // /questions/9731/fastest-gun-in-the-west-problem
        public ActionResult Display(int id, string url, int page = 1)
        {
            return Content(id + "   " + url);
        }

        // /questions/tagged/javascript
        public ActionResult GetByTag(string tag)
        {
            return Content(tag);
        }

        //GET-POST-REDIRECT
        [HttpGet]
        public ActionResult Ask()
        {
            var model = new AskInputModel();
            return this.View(model);
        }

        [HttpPost]
        public ActionResult Ask(AskInputModel input)
        {
            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Title = input.Title,
                    Content = input.Content
                    //TODO: Tags
                    //TODO: Author
                };
                this.posts.Add(post);
                this.posts.SaveChanges();
                return this.RedirectToAction("Display", new { id = post.Id, url = "new" });
            }

            return this.View(input);
        }
    }
}
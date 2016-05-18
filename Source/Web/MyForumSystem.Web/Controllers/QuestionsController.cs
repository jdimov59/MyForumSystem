﻿using MyForumSystem.Data.Common.Repository;
using MyForumSystem.Data.Models;
using MyForumSystem.Web.InputModels.Questions;
using System.Web.Mvc;
using MyForumSystem.Web.ViewModels.Questions;
using System.Linq;
using AutoMapper.QueryableExtensions;
using MyForumSystem.Web.Infrastructure;

namespace MyForumSystem.Web.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly IDeletableEntityRepository<Post> posts;

        private readonly ISanitizer sanitizer;

        public QuestionsController(IDeletableEntityRepository<Post> posts, ISanitizer sanitizer)
        {
            this.posts = posts;
            this.sanitizer = sanitizer;
        }

        // /questions/9731/fastest-gun-in-the-west-problem
        public ActionResult Display(int id, string url, int page = 1)
        {
            var postViewModel = this.posts.All().Where(x => x.Id == id).ProjectTo<QuestionDisplayViewModel>().FirstOrDefault();

            if (postViewModel == null)
            {
                return this.HttpNotFound("Not suck post");
            }
            return View(postViewModel);
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
                    Content = sanitizer.Sanitize(input.Content)
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
using MyForumSystem.Web.InputModels.Questions;
using System.Web.Mvc;

namespace MyForumSystem.Web.Controllers
{
    public class QuestionsController : Controller
    {
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
            return Content("Ask GET");
        }

        [HttpPost]
        public ActionResult Ask(AskInputModel input)
        {
            return Content("Ask POST");
        }
    }
}
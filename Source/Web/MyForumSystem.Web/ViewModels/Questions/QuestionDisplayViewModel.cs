using MyForumSystem.Web.Infrastructure.Mapping;
using MyForumSystem.Data.Models;

namespace MyForumSystem.Web.ViewModels.Questions
{
    public class QuestionDisplayViewModel : IMapFrom<Post>
    {
        public string Title { get; set; }

        public string Content {get;set;}
    }
}
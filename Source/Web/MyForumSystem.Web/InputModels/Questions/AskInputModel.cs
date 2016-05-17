using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyForumSystem.Web.InputModels.Questions
{
    public class AskInputModel
    {
        [Display(Name = "Title")]
        public string Title { get; set; }

        [AllowHtml]
        [Display(Name = "Content")]
        [DataType(DataType.MultilineText)]
        [UIHint("tinymce_full")]
        public string Content { get; set; }

        [Display(Name = "Tags")]
        public string Tags { get; set; }
    }
}
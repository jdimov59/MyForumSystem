﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyForumSystem.Web.InputModels.Questions
{
    public class AskInputModel
    {
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [AllowHtml]
        [Display(Name = "Content")]
        [UIHint("tinymce_full")]
        public string Content { get; set; }

        //TODO: Create custom validation for the tags
        [Required]
        [Display(Name = "Tags")]
        public string Tags { get; set; }
    }
}
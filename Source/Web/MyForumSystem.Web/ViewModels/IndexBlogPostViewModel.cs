using MyForumSystem.Data.Models;
using MyForumSystem.Web.Infrastructure.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyForumSystem.Web.ViewModels
{
    public class IndexBlogPostViewModel: IMapFrom<Post>
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
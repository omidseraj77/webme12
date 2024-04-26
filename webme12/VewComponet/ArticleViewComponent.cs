using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using webme12.Models;


namespace webme12.VewComponet
{
    public class ArticleViewComponent : ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1,"اموزش mvc ","mvc","blog-post-thumb-card-1.jpg"),
                new Article(2,"اموزش php ","php","blog-post-thumb-card-2.jpg"),
                new Article(3,"اموزش python ","python","blog-post-thumb-card-3.jpg"),
                new Article(4,"اموزش css ","css","blog-post-thumb-card-4.jpg")

            };
            asdasd


            return View("_Atricles",article);
        }
    }
}

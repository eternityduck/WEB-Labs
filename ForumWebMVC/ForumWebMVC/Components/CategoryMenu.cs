using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ForumWebMVC.Components
{
    public class CategoryMenu:ViewComponent
    {
        private readonly ITopicService _topicService;

        public CategoryMenu(ITopicService topicService)
        {
            _topicService = topicService;
        }


        public IViewComponentResult Invoke()
        {
            var categories = _topicService.GetAllAsync().Result.OrderBy(x => x.Title);
            return View(categories);
        }
    }
}
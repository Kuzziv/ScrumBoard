using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoriesPro.Service.Interface;

namespace StoriesPro.Pages.UserStories
{
    public class GetAllUserStoriesModel : PageModel
    {
        private IUserStoryService _iuserStoryService;
        public List<Models.UserStory> UserStories { get; private set; }

        public GetAllUserStoriesModel(IUserStoryService userStoryService)
        {
            _iuserStoryService = userStoryService;
        }

        public void OnGet()
        {
            UserStories = _iuserStoryService.GetUserStoryList();
        }
    }
}

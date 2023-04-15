using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoriesPro.Models;
using StoriesPro.Service.Interface;

namespace StoriesPro.Pages.UserStories
{
    public class UserStoryDetailModel : PageModel
    {
        private IUserStoryService _iuserStoryService;

        [BindProperty] public UserStory UserStory { get; set; }
        public List<UserStory> UserStories { get; private set; }

        public UserStoryDetailModel(IUserStoryService userStoryService)
        {
            _iuserStoryService = userStoryService;
        }

        public void OnGet(int id)
        {
            UserStories = _iuserStoryService.GetUserStoryList();
            UserStory = _iuserStoryService.GetUserStoryById(id);
        }
    }
}

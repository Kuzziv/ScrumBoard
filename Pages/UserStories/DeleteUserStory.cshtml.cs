using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoriesPro.Models;
using StoriesPro.Service.Interface;

namespace StoriesPro.Pages.UserStories
{
    public class DeleteUserStoryModel : PageModel
    {
        private IUserStoryService _iuserStoryService;

        [BindProperty] public UserStory userStory { get; set; }

        public DeleteUserStoryModel(IUserStoryService userStoryService)
        {
            _iuserStoryService = userStoryService;
        }

        public void OnGet(int id)
        {
            userStory = _iuserStoryService.GetUserStoryById(id);
        }

        public IActionResult OnPost()
        {
            UserStory deletedUserStory = _iuserStoryService.DeleteUserStoryById(userStory.Id);
            return RedirectToPage("GetAllUserStories");
        }
    }
}

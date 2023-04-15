using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoriesPro.Models;
using StoriesPro.Service.Interface;

namespace StoriesPro.Pages.UserStories
{
    public class CreateUserStoryModel : PageModel
    {
        private IUserStoryService _iuserStoryService;

        [BindProperty] public UserStory UserStory { get; set; }

        public CreateUserStoryModel(IUserStoryService userStoryService)
        {
            _iuserStoryService = userStoryService;
        }

        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _iuserStoryService.AddUserStory(UserStory);
            return RedirectToPage("GetAllUserStories");
        }
    }
}

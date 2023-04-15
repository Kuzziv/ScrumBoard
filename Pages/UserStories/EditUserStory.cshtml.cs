using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StoriesPro.Models;
using StoriesPro.Service.Interface;

namespace StoriesPro.Pages.UserStories
{
    public class EditUserStoryModel : PageModel
    {
        private IUserStoryService _iuserStoryService;

        [BindProperty] public UserStory UserStory { get; set; }

        public EditUserStoryModel(IUserStoryService userStoryService)
        {
            _iuserStoryService = userStoryService;
        }

		public IActionResult OnGet(int id)
		{
			UserStory = _iuserStoryService.GetUserStoryById(id);
			if (UserStory == null)
			{
                return Page();
			}
			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_iuserStoryService.UpdateUserStory(UserStory);
			return RedirectToPage("GetAllUserStories");
		}
	}
}

using StoriesPro.Models;
using StoriesPro.Service.Interface;
using StoriesPro.Service.JSONService;

namespace StoriesPro.Service.DataService
{
	public class UserStoryService : IUserStoryService
	{      
        private JsonFileService<UserStory> _jsonFileService;

        List<UserStory> _userStories;

        public UserStoryService(JsonFileService<UserStory> jsonFileService)
        {
            _jsonFileService = jsonFileService;
            _userStories = _jsonFileService.GetJsonObjects().ToList();
        }

        public List<UserStory> GetUserStoryList()
		{
            return _userStories;
		}

        public UserStory GetUserStoryById(int id)
        {
            foreach (var userStory in _userStories)
            {
                if (userStory.Id == id)
                {
                    return userStory;
                }
            }
            return null;
        }

        public UserStory DeleteUserStoryById(int id)
        {
            UserStory userStoryToBeDelete = null;
            foreach (var userStory in _userStories)
            {
                if(id == userStory.Id)
                {
                    userStoryToBeDelete = userStory;
                }
            }

            if (userStoryToBeDelete != null)
            {
                _userStories.Remove(userStoryToBeDelete);
            }
            return userStoryToBeDelete;
        }

        public void AddUserStory(UserStory userStory)
        {
            _userStories.Add(userStory);
            _jsonFileService.SaveJsonObjects(_userStories);

        }

		public void UpdateUserStory(UserStory userStory)
		{
			if (userStory != null)
			{
				foreach (UserStory userSt in _userStories)
				{
					if (userSt.Id == userStory.Id)
					{
						userSt.Title = userStory.Title;
						userSt.Description = userStory.Description;
						userSt.BusinessValue = userStory.BusinessValue;
						//userSt.CreationDate = DateTime.Now;
						userSt.Priority = userStory.Priority;
						userSt.StoryPoints = userStory.StoryPoints;
					}
				}
                _jsonFileService.SaveJsonObjects(_userStories);
			}
		}
	}
}

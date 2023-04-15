using StoriesPro.Models;

namespace StoriesPro.Service.Interface
{
	public interface IUserStoryService
	{
		public List<UserStory> GetUserStoryList();

		UserStory GetUserStoryById(int id);

		UserStory DeleteUserStoryById(int id);
		
		void AddUserStory(UserStory userStory);
		void UpdateUserStory(UserStory userStory);

	}
}

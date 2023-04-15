using StoriesPro.Models;

namespace StoriesPro.MockData
{
	public class MockUserStories
	{
		private static List<UserStory> userStories = new List<UserStory>()
		{
			 new UserStory(1, "Create Story", "As P.O I want to create a new Story So ...", 8, DateTime.Now, 7, "This is a must"),
			 new UserStory(2, "Edit Story", "As P.O I want to edit a Story So ...", 9, DateTime.Now, 6, "This is a must/Nice to have"),
			 new UserStory(3, "Move Story", "As team member I want to move a Story So ...", 9, DateTime.Now, 10, "This is a new"),
			 new UserStory(4, "Delete Story", "As team member I want to delete a Story So ...", 10, DateTime.Now, 10, "This is a must")
		};

		public static List<UserStory> GetUserStories() { return userStories; }
	}
}

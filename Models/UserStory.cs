namespace StoriesPro.Models
{
	public class UserStory
	{
        public int Id { get; set; }
		public string Title { get; set; }
        public string Description { get; set; }
		public int BusinessValue { get; set; }
        public DateTime CreationDate { get; set; }
        public int Priority { get; set; }
        public string StoryPoints { get; set; }


        public UserStory(int id, string title, string description, int businessValue, DateTime creationDate ,int priority, string storyPoints)
		{
			Id = id;
			Title = title;
			Description = description;
            BusinessValue = businessValue;
            CreationDate = creationDate;
            Priority = priority;
            StoryPoints = storyPoints;
		}

        public UserStory()
        {
            
        }
    }
}

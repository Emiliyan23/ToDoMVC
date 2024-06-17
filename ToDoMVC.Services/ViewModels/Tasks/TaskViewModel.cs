namespace ToDoMVC.Models.Tasks
{
	public class TaskViewModel
	{
		public int Id { get; set; }

		public string Title { get; set; } = null!;

		public DateTime DueDate { get; set; }

		public DateTime CreatedOn { get; set; }

		public bool Completed { get; set; }
	}
}

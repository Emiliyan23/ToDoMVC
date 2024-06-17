namespace ToDoMVC.Services.Interfaces
{
	using Models.Tasks;

	public interface ITaskService
	{
		Task<List<TaskViewModel>> GetAllTasksAsync(string userId);
	}
}

namespace ToDoMVC.Services
{
	using Microsoft.EntityFrameworkCore;

	using Models.Tasks;
	using Interfaces;
	using Data;

	public class TaskService : ITaskService
	{
		private readonly ApplicationDbContext _context;

		public TaskService(ApplicationDbContext context)
		{
			_context = context;
		}

		public async Task<List<TaskViewModel>> GetAllTasksAsync(string userId)
		{
			var userTasks = await _context.Tasks
				.Where(t => t.UserId == Guid.Parse(userId))
				.OrderBy(t => t.DueDate)
				.Select(t => new TaskViewModel
				{
					Id = t.Id,
					Title = t.Title,
					DueDate = t.DueDate,
					CreatedOn = t.CreatedOn,
					Completed = t.Completed
				})
				.ToListAsync();

			return userTasks;
		}
	}
}

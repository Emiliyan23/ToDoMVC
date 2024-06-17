namespace ToDoMVC.Controllers
{
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;

	using Extensions;
	using Services.Interfaces;

	[Authorize]
	public class TasksController : Controller
	{
		private readonly ITaskService _taskService;

		public TasksController(ITaskService taskService)
		{
			_taskService = taskService;
		}

		public async Task<IActionResult> All()
		{
			var userTasks = await _taskService.GetAllTasksAsync(User.Id());

			return View();
		}
	}
}

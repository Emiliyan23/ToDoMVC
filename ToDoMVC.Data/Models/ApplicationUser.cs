namespace ToDoMVC.Data.Models
{
	using Microsoft.AspNetCore.Identity;

	public class ApplicationUser : IdentityUser<Guid>
	{
		public ICollection<Task> Tasks { get; set; } = new List<Task>();
	}
}

namespace ToDoMVC.Data.Models
{
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public class Task
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Title { get; set; } = null!;

		public DateTime DueDate { get; set; }

		public DateTime CreatedOn { get; set; }

		public bool Completed { get; set; }

		[ForeignKey(nameof(User))]
		public Guid UserId { get; set; }

		public ApplicationUser User { get; set; } = null!;
	}
}

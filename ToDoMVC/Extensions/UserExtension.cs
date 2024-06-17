namespace ToDoMVC.Extensions
{
	using System.Security.Claims;
	public static class UserExtension
	{
		public static string? Id(this ClaimsPrincipal user)
		{
			var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier);

			return userIdClaim?.Value;
		}
	}
}

using System.ComponentModel.DataAnnotations;

namespace GCD0702AppDev.Models
{
	public class Category
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
	}
}
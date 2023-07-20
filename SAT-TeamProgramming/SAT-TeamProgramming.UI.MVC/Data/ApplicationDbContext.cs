using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SAT_TeamProgramming.UI.MVC.Models;

namespace SAT_TeamProgramming.UI.MVC.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
		public DbSet<SAT_TeamProgramming.UI.MVC.Models.ContactViewModel>? ContactViewModel { get; set; }
	}
}
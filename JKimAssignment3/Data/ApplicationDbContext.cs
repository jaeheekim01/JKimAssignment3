using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JKimAssignment3.Models;

namespace JKimAssignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JKimAssignment3.Models.Actor> Actor { get; set; }
        public DbSet<JKimAssignment3.Models.Movie> Movie { get; set; }
        public DbSet<JKimAssignment3.Models.MovieActor> MovieActor { get; set; }
    }
}
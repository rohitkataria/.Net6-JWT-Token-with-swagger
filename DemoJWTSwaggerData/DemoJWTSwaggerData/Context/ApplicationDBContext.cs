using DemoJWTSwaggerData.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoJWTSwaggerData.Context
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public virtual DbSet<User> User { get; set; }
    }
}

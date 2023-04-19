using Microsoft.EntityFrameworkCore;

namespace EntityTest.Data
{
    public class StudentDbContext :DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public DbSet<Models.StudentModel> Students { get; set; }
    }
}

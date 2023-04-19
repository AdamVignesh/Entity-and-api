using ApiWithEntity_test.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiWithEntity_test.Data
{
    public class JobDbContext : DbContext
    {

        public JobDbContext(DbContextOptions<Data.JobDbContext> options) :base(options){}
        public DbSet<JobsModel> JobsTable { get; set; }

    }
}


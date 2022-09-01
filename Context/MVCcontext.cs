using EFMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EFMVC.Context
{
    public class MVCcontext: DbContext
    {
        public MVCcontext(DbContextOptions options):base(options)
        {

        }

        //Entities
        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

    }
}

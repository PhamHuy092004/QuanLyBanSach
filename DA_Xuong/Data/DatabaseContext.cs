using DA_Xuong.Models;
using Microsoft.EntityFrameworkCore;

namespace DA_Xuong.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        //public DbSet<SACH> SACH { get;set; }
    }
}

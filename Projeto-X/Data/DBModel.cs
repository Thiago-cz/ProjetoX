using Microsoft.EntityFrameworkCore;
using Projeto_X.Models;

namespace Projeto_X.Data
{
    public class DBModel : DbContext
    {
        public DBModel(DbContextOptions<DBModel> opts) : base(opts)
        {

        }
        public DbSet<Videos> Videos { get; set; }
    }
}

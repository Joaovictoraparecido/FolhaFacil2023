using Microsoft.EntityFrameworkCore;

namespace FolhaFacil2023.Models
{
    public class BancoFuncDbcontext: DbContext

    {
        public BancoFuncDbcontext(DbContextOptions<BancoFuncDbcontext> options) : base(options) 
        
        {
        
        }

        public DbSet<Funcionarios> Funcionarios { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;
using WebAPI_Estudo.Models;

namespace WebAPI_Estudo.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }

        //vai criar a tabela funcionarios dentro do banco e ela vai ter a estrutura de funcionariomodel
        public DbSet<FuncionarioModel> Funcionarios { get; set; }

    }
}

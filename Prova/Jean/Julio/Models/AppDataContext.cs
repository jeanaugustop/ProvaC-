using Microsoft.EntityFrameworkCore;

namespace Julio.Models;

//Classe que representa o EF dentro do projeto
public class AppDataContext : DbContext
{
    //Classes que vão representar as tabelas no banco de dados
    public DbSet<Funcionario> Funcionario { get; set; }
    public DbSet<Folha> Folha { get; set; }


    //Configurando qual o banco de dados vai ser utilizado
    //Configurando a string de conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=jean_julio.db");
    }
}
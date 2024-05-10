using System.ComponentModel.DataAnnotations;
namespace Julio.Models;
public class Funcionario{

    public Funcionario(){

    }

    public Funcionario(int id, string nome, string cpf){
        int Id = id;
        string Nome = nome;
        string Cpf = cpf;
    }

    public int? id { get; set; }
    public string? nome { get; set; }
    public string? cpf { get; set; }
}
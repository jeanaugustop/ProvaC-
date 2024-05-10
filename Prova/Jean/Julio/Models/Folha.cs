using System.ComponentModel.DataAnnotations;
namespace Julio.Models;
public class Folha{

    public Folha(){

    }

    public Folha(double valor, int quantidade, int mes, int ano, int id){
        int Id = id;
        double Valor = valor;
        int Quantidade = quantidade;
        int Mes = mes;
        int Ano = ano;
    }

    public int? Id { get; set;}
    public double? valor { get; set; }
    public int? quantidade { get; set; }
    public int? mes { get; set; }
    public int? ano { get; set; }
}
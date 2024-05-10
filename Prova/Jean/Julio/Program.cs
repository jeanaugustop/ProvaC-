using System.ComponentModel.DataAnnotations;
using Julio.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// registrar o serviço de banco de dados na aplicação
builder.Services.AddDbContext<AppDataContext>();

var app = builder.Build();


//EndPoints - Funcionalidades
//GET: http://localhost:5225/
app.MapGet("/", () => "Minha primeira API em C# com watch");


//POST: http://localhost:5205/api/funcionario/cadastrar
app.MapPost("/api/funcionario/cadastrar",
    ([FromBody] Funcionario funcionario,
     [FromServices] AppDataContext ctx) =>
{
    //Adicionar o funcionario dentro da lista (BD)
    ctx.Add(funcionario);
    ctx.SaveChanges();
    return Results.Created("", funcionario);
});

//POST: http://localhost:5205/api/folha/cadastrar
app.MapPost("/api/folha/cadastrar",
    ([FromBody] Folha folha,
     [FromServices] AppDataContext ctx) =>
{
    //Adicionar o funcionario dentro da lista (BD)
    ctx.Add(folha);
    ctx.SaveChanges();
    return Results.Created("", folha);
});



//GET: http://localhost:5205/api/funcionario/listar
app.MapGet("/api/funcionario/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Funcionario.Any())
    {
        return Results.Ok(ctx.Funcionario.ToList());
    }

    return Results.NotFound("NAO TEM NENHUM FUNCIONARIO CADASTRADO");

});

//GET: http://localhost:5205/api/folha/listar
app.MapGet("/api/folha/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Folha.Any())
    {
        return Results.Ok(ctx.Folha.ToList());
    }

    return Results.NotFound("NAO TEM FOLHA CADASTRADA");

});

/*
//GET: http://localhost:5225/api/produto/buscar/id_do_produto
app.MapGet("/api/folha/buscar/{id}", ([FromRoute] int id, [FromServices] AppDataContext ctx) =>
{
    if(folha is null){
        Folha? folha = ctx.Folha.FirstOrDefault(x => x.Id == id);
        // Produto não encontrado
        return Results.NotFound("Folha não encontrada!");
    }
    return Results.Ok(folha);   
});
*/

app.Run();
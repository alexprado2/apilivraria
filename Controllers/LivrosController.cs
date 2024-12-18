using ApiLivraria.Communication.Requests;
using ApiLivraria.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLivraria.Controllers;
public class LivrosController : LivrariaBaseController
{

    [HttpGet("{Id}")]
    [ProducesResponseType(typeof(ResponseRegisterLivroJson), StatusCodes.Status200OK)]
    public IActionResult GetById()
    {
        var response = new ResponseRegisterLivroJson
        {
            Id = 1,
            Titulo = "João e Maria",
            Autor = "João",
            Genero = "Aventura",
            Preco = 19.90F,
            QtdEstoque = 20,
        };

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseRegisterLivroJson>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<ResponseRegisterLivroJson>()
        {
           new ResponseRegisterLivroJson { Id = 1, Titulo = "João e Maria", Autor = "João", Genero = "Aventura", Preco = 19.90F, QtdEstoque = 20 },
           new ResponseRegisterLivroJson { Id = 2, Titulo = "Branca de Neve", Autor = "João", Genero = "Aventura", Preco = 59.90F, QtdEstoque = 20 },
        };

        return Ok(response);s
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterLivroJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterLivroJson request)
    {
        var livro = new ResponseRegisterLivroJson
        {
            Id = request.Id,
            Titulo = request.Titulo,
            Autor = request.Autor,
            Genero = request.Genero,
            Preco = request.Preco,
            QtdEstoque = request.QtdEstoque,
        };
        return Created(string.Empty, livro);
    }

    [HttpPut("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public IActionResult Update(
        [FromRoute] int Id,
        [FromBody] RequestUpdateLivroJson request)
    {
        return Ok(request);
    }

    [HttpDelete("{Id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public IActionResult Delete(
        [FromRoute] int Id,
        [FromBody] RequestDeleteLivroJson request)
    {
        return Ok(request);
    }

}
 
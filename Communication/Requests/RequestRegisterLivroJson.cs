namespace ApiLivraria.Communication.Requests;

public class RequestRegisterLivroJson
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public string Autor { get; set; } = string.Empty;
    public string Genero { get; set; } = string.Empty;
    public float Preco { get; set; }
    public int QtdEstoque { get; set; }

}

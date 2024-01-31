using System.Text.Json.Serialization;

namespace Desafio02.Models.Book;

public class BookModel
{
     [JsonPropertyName("titulo")]
    public string? Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string? Autor { get; set; }
    [JsonPropertyName("ano_publicacao")]
    public int? Ano { get; set; }
    [JsonPropertyName("genero")]
    public string? Genero { get; set; }
    [JsonPropertyName("paginas")]
    public int? Paginas { get; set; }
    [JsonPropertyName("editora")]
    public string? Editora { get; set; }

    public void ShowBooksDetais()
    {
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Paginas: {Paginas}");
        Console.WriteLine($"Editora: {Editora}");

    }
}
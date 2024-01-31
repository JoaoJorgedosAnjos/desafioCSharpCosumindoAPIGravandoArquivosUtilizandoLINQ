using System.Text.Json.Serialization;

namespace Desafio02.Models.Film;

internal class FilmModel
{
    [JsonPropertyName("title")]
    public string? Tittle { get; set; }
    [JsonPropertyName("year")]
    public string? Year { get; set; }
    [JsonPropertyName("crew")]
    public string? Crew { get; set; }
    [JsonPropertyName("imDbRating")]
    public string? Rating { get; set; }

    public void ShowFilmsDetais()
    {
        Console.WriteLine($"Titulo: {Tittle}");
        Console.WriteLine($"Ano: {Year}");
        Console.WriteLine($"Equipe: {Crew}");
        Console.WriteLine($"Nota: {Rating }");
    }
}
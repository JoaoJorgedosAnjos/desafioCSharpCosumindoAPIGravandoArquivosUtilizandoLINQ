using System.Text.Json;
using Desafio02.Models.Book;
using Desafio02.Models.Car;
using Desafio02.Models.Country;
using Desafio02.Models.Film;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var films = JsonSerializer.Deserialize<List<FilmModel>>(response);
        foreach (var film in films)
        {
            film.ShowFilmsDetais();
            Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var countries = JsonSerializer.Deserialize<List<CountryModel>>(response);
        foreach (var country in countries)
        {
            country.ShowCountriesDetais();
            Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}
using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var cars = JsonSerializer.Deserialize<List<CarModel>>(response);
        foreach (var car in cars)
        {
            car.ShowCarDetais();
            Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}
using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var books = JsonSerializer.Deserialize<List<BookModel>>(response);
        foreach (var book in books)
        {
            book.ShowBooksDetais();
            Console.WriteLine();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}
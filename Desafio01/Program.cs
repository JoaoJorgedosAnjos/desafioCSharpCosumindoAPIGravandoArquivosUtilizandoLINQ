//Exercicio 01
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
//Exercicio 02
try
{
    Console.Write("Digite o numerador: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Digite o denominador: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine(a / b);
}
catch (Exception ex)
{
    Console.WriteLine($"Tivemos um problema: {ex.Message}");
    Console.WriteLine($"Erro: na matemática não é permitida a divisão por 0.");
}
//Exercicio 03
List<int> lista1 = new List<int>()
{
1,2,3,4,5,6,7,8,9,10
};
try
{
    Console.WriteLine(lista1[11]);
}
catch (Exception ex)
{
    Console.WriteLine($"Temos um problema: {ex.Message}");
}
//ou 
try
{
    List<int> numeros = new List<int> { 1, 2, 3 };
    Console.WriteLine($"Elemento no índice 5: {numeros[5]}");
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

//Exercicio 04
try
{
    MinhaClasse objetoNulo = null;
    objetoNulo.Meumetodo();
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}

internal class MinhaClasse
{
    internal void Meumetodo()
    {
        
    }
}
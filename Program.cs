using ExceptionHandling.Models;

new ExceptionExemple().Metodo1();


try
{
    string[] readFile = File.ReadAllLines("Files/tex/eadFile.txt");

    foreach(var line in readFile)
    {
        Console.WriteLine(line);
    }
}
catch(FileNotFoundException ex) //exceção específica
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex) //exceção específica
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch (Exception ex) //exceção genérica
{
    Console.WriteLine($"Exceção genérica capturada. Mensagem: {ex.Message}");
}
finally //Será executado independente de ter acontecido um erro ou não.
{
    Console.WriteLine("Fechando conexão com o banco");
}
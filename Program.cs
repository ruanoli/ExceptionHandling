string[] readFile = File.ReadAllLines("Files/readFile.txt");

foreach(var line in readFile)
{
    Console.WriteLine(line);
}
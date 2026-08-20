public class FileLogger : ILogger
{
    private string _filePath;
    public FileLogger(string filePath){ _filePath = filePath;}

    public void Log(string level, string message)
    {
        Console.WriteLine($"Writing to {_filePath}: [{level}] {message}");
    }
    public string GetDestination()
    {
        return $"File: {_filePath}";
    }
}
public class ConsoleLogger : ILogger
{
    public void Log(string level, string message)
    {
        Console.WriteLine($"[{level}] {message}");
    }

    public string GetDestination()
    {
        return "Console";
    }
}
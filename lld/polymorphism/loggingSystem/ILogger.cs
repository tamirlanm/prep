public interface ILogger
{
    void Log(string level, string message);
    string GetDestination();
}
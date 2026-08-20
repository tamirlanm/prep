public class DatabaseLogger : ILogger
{
    private string _tableName;
    public DatabaseLogger(string tableName) {_tableName = tableName;}

    public void Log(string level, string message)
    {
        Console.WriteLine($"INSERT INTO {_tableName}: [{level}] {message}");
    }

    public string GetDestination()
    {
        return $"Database: {_tableName}";
    }
}
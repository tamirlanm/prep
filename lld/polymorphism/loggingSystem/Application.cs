public class Application
{
    private ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void Run()
    {
        _logger.Log("INFO", "Application starting...");
        _logger.Log("INFO", "Processing data...");
        _logger.Log("INFO", "Application shutting down.");
    }
}
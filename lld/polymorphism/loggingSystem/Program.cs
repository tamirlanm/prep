var loggers = new List<ILogger>
        {
            new ConsoleLogger(),
            new FileLogger("/var/log/app.log"),
            new DatabaseLogger("app_logs")
        };

        foreach (var logger in loggers)
        {
            Console.WriteLine($"--- Using {logger.GetDestination()} ---");
            var app = new Application(logger);
            app.Run();
            Console.WriteLine();
        }
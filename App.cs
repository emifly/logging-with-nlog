using Microsoft.Extensions.Logging;

namespace LoggingWithNLog;

public class App
{
    private readonly ILogger<App> _logger;

    public App(ILogger<App> logger)
    {
        _logger = logger;
    }

    public void Run()
    {
        _logger.LogInformation("App starting.");
    }
}

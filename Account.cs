using Microsoft.Extensions.Logging;

namespace LoggingWithNLog;

public class Account
{
    public required string Name { get; set; }
    public List<string> Transactions { get; } = [];

    private readonly ILogger<Bank> _logger;

    public Account(ILogger<Bank> logger)
    {
        _logger = logger;
    }

    public void AddTransaction(string description)
    {
        _logger.LogInformation($"Adding transaction '{description}' for {Name}...");
        Transactions.Add(description);
        _logger.LogInformation($"Transaction added for {Name}.");
    }
}

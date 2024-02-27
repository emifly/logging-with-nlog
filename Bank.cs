using Microsoft.Extensions.Logging;

namespace LoggingWithNLog;

public class Bank
{
    public List<Account> Accounts { get; } = [];

    private readonly ILogger<Bank> _logger;

    public Bank(ILogger<Bank> logger)
    {
        _logger = logger;
    }

    public void LetsGo()
    {
        _logger.LogInformation("App starting.");
        Console.Write("Enter your name: ");
        var accountName = Console.ReadLine() ?? "";
        var newAccount = new Account(_logger)
        {
            Name = accountName,
        };
        Accounts.Add(newAccount);
        _logger.LogInformation($"New account created for {accountName}.");
        newAccount.AddTransaction("Cake from Tesco");
    }
}

using LoggingWithNLog;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

var servicesProvider = new ServiceCollection()
    .AddTransient<App>()
    .AddLogging(loggingBuilder =>
    {
        loggingBuilder.ClearProviders();
        loggingBuilder.AddNLog();
    })
    .BuildServiceProvider();

var app = servicesProvider.GetRequiredService<App>();
app.Run();

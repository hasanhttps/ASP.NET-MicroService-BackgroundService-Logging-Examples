
namespace ProductCommandMicroService.BackgroundServices;

public class DateTimeLogWriter : IHostedService {

    // Fields

    private readonly ILogger<DateTimeLogWriter> _logger;

    // Constructor

    public DateTimeLogWriter(ILogger<DateTimeLogWriter> logger) {
        _logger = logger;
    }

    // Methods

    public async Task StartAsync(CancellationToken cancellationToken) {
        _logger.LogInformation($"{nameof(DateTimeLogWriter)} Service started ...");

        while (!cancellationToken.IsCancellationRequested) {
            WriteDateTimeOnLog();
            await Task.Delay(1000);
        }
    }

    private void WriteDateTimeOnLog() {
        _logger.LogInformation($"Datetime is {DateTime.Now.ToLongTimeString()}");
    }

    public Task StopAsync(CancellationToken cancellationToken) {
        _logger.LogInformation($"{nameof(DateTimeLogWriter)} Service stoped ...");
        return Task.CompletedTask;
    }
}

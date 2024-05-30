using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Worker_Service_Sample;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<WorkerService>();
    })
    .Build();

await host.RunAsync();

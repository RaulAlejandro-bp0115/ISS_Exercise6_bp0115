using ModuleVS_bp0115;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>services.AddHostedService<ModuleBackgroundService>())
    .Build();

host.Run();
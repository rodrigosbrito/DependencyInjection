using DependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<SingletonService>();
builder.Services.AddScoped<ScopedService>();
builder.Services.AddTransient<TransientService>();

var app = builder.Build();

app.MapGet("/", 
    (
        SingletonService singletonService,
        ScopedService scopedService,
        TransientService transientService) => new 
        {
            RequestId = Guid.NewGuid(),
            SingletonServiceId = singletonService.RequestId,
            ScopedService = new 
            {
                Id = scopedService.Id,
                SingletonServiceId = scopedService.SingletonServiceId
            },
            TransientService = new 
            {
                Id = transientService.Id,
                SingletonServiceId = transientService.SingletonServiceId,
                ScopedServiceId = transientService.ScopedServiceId,
                ScopedServiceNewInstanceId = transientService.ScopedServiceId
            }
        });

app.Run();

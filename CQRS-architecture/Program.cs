using BusinessLogic;
using BusinessLogic.Abstractions.Behaviours;
using BusinessLogic.Abstractions.Caching;
using BusinessLogic.Caching;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
{
    builder.Services.AddMediatR(cfg => 
    {
        cfg.RegisterServicesFromAssemblies(assembly);

        cfg.AddOpenBehavior(typeof(QueryCachingPipelineBehavior<,>));
    });

}

builder.Services.AddSingleton<FakeDataStore>();

builder.Services.AddMemoryCache();
builder.Services.AddSingleton<ICacheService, CacheService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

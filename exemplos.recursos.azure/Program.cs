using Microsoft.Extensions.Configuration.AzureAppConfiguration;

var builder = WebApplication.CreateBuilder(args);

// ------- Inicio :: Configuração do AppConfiguration Azure
builder.Configuration.AddAzureAppConfiguration( op =>
    {
        op.Connect(Environment.GetEnvironmentVariable("ConnectionStringAzure"))
            .Select(KeyFilter.Any, builder.Environment.EnvironmentName);
    });

builder.Services.AddAzureAppConfiguration();
// ------- Final :: Configuraçao do AppConfigurationAzure

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
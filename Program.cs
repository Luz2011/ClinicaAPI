using ClinicaAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar controladores
builder.Services.AddControllers();

// Configurar DbContext con MySQL
builder.Services.AddDbContext<ClinicaContext>(options =>
    options.UseMySql(
        builder.Configuration.GetConnectionString("MySQLConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySQLConnection"))
    )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar Swagger solo en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
using Microsoft.EntityFrameworkCore;
using Repository_pattern_with_UOW.core.Repository;
using Repository_pattern_with_UOW.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Add DB Context
//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<ApplicationDBContext>(x => x.UseSqlServer(configuration.));
builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient(typeof(IBaseRepository<>), typeof(IBaseRepository<>));
//b => b.MigrationAssembly(typeof(ApplicationDBContext).Assembly.FullName)));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

using Tutorial4.Databases;
using Tutorial4.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IAnimalService,AnimalService>();
builder.Services.AddScoped<IVisitService,VisitService>();
builder.Services.AddScoped<IVisitDb, VisitDb>();
builder.Services.AddScoped<IAnimalDb, AnimalDb>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Controllers
app.MapControllers();

app.Run();
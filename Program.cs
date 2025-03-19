var builder = WebApplication.CreateBuilder(args);

// Add þjónustum við í container
builder.Services.AddControllers();
// Bæta við Swagger fyirr API prófun
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Stilla verkferli fyrir HTTP beiðnir.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

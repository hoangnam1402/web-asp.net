var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<WebContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
app.MapGet("/", () => "Hello World!");

app.Run();

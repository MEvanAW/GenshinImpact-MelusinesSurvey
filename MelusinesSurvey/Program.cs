var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new
    List<string> { "melusines_survey.html" }
});
app.UseStaticFiles();
app.MapControllers();
app.Run();

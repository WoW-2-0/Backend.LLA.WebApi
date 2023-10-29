using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;

    // Reading only from X-API-Version header
    // options.ApiVersionReader = new HeaderApiVersionReader("X-API-Version");

    // Reading only from Accept header
    // options.ApiVersionReader = new MediaTypeApiVersionReader();

    // Reading from both headers
    options.ApiVersionReader = ApiVersionReader.Combine(
        new HeaderApiVersionReader("X-API-Version"),
        new MediaTypeApiVersionReader("version"));
});
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.Run();
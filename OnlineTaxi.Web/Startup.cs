using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace OnlineTaxi.Web;

public static class Startup
{
    public static void ConfigureService(IServiceCollection service)
    {
        
    }

    public static void Configure(WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");
    }
}
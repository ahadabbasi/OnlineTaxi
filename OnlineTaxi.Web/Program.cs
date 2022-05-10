using Microsoft.AspNetCore.Builder;

namespace OnlineTaxi.Web;

public static class Program
{
    public static void Main(params string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        
        Startup.ConfigureService(builder.Services);
        
        WebApplication app = builder.Build();

        Startup.Configure(app);

        app.Run(); 
    }
}
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sealgram;
using Sealgram.Data;

public class TestFixture : WebApplicationFactory<proram>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            // Replace the actual database context with an in-memory database for testing
            services.AddDbContext<SealgramDbContext>(options =>
                options.UseInMemoryDatabase("TestDatabase"));

            // Optional: You can also override any other services or dependencies here if needed.

            // Disable logging for tests
            services.AddSingleton<ILoggerFactory, NullLoggerFactory>();
        });
    }
}
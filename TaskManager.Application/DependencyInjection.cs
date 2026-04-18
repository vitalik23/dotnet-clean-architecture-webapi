using Microsoft.Extensions.DependencyInjection;
using TaskManager.Application.Profiles;
using TaskManager.Application.Services;

namespace TaskManager.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<TaskService>();

        services.AddAutoMapper(config =>
        {
            config.AddProfile(new TaskProfile());
        });

        return services;
    }
}
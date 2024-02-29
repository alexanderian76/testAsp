using System;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Options;
using TestAsp.Models;

public class Configuration
{
    public Configuration(IServiceCollection services)
    {
        services.AddDbContext<MobileContext>();
        services.AddControllersWithViews().AddJsonOptions(options =>
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles
);
        services.AddControllers();
        services.AddScoped<IBaseEditableRepository<Phone>, PhoneRepository>();
        services.AddScoped<IPhoneService, PhoneService>();
    }
}



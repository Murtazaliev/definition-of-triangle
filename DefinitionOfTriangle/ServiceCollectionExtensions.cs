using DefinitionOfTriangle.App;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefinitionOfTriangle
{
    public class ServiceCollectionExtensions
    {
        public static IServiceCollection CreateServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<IDefinitionOfTriangleService, DefinitionOfTriangleService>();
            return services;
        }
    }
}

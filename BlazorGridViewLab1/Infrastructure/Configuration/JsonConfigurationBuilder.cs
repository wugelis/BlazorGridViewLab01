using Microsoft.Extensions.Configuration;
using MingChi.Infrastructure.Configuration.CRMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.Infrastructure.Configuration
{
    public class JsonConfigurationBuilder : IJsonConfigurationBuilder
    {
        public string GetConnectionString()
        {
            string basePath = System.AppContext.BaseDirectory;
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appSettings.json")
                .Build();

            return configuration.GetConnectionString("Conn");
        }
    }
}

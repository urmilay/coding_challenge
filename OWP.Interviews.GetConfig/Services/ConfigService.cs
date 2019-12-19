namespace OWP.Interviews.GetConfig.Services
{
    using System;
    using System.Collections.Generic;

    public class ConfigService : IConfigService
    {
        public ConfigService()
        {
        }

        public Dictionary<string, string> GetConfig(string vendor, string env)
        {
            if (vendor == "VendorA")
            {
                var config = new Dictionary<string, string>();
                config.Add("base_price", "$12");
                config.Add("timeout", "30");
                if (env == "stage")
                {
                    // add env code
                    config.Add("database", "mongodb://stage.db.local:1111");
                    return config;
                }
                if (env == "prod")
                {
                    config.Add("database", "mongodb://prod.db.local:1111");
                    return config;
                }
                else
                {
                    config.Add("database", "mongodb://my.db.local:1111");
                    return config;
                }
            }
            if (vendor == "VendorB")
            {
                var config = new Dictionary<string, string>();
                config.Add("base_price", "$20");
                config.Add("timeout", "30");
                if (env == "stage")
                {
                    // add env code
                    config.Add("database", "mongodb://stage.db.local:1111");
                    return config;
                }
                if (env == "prod")
                {
                    config.Add("database", "mongodb://prod.db.local:1111");
                    return config;
                }
                else
                {
                    config.Add("database", "mongodb://my.db.local:1111");
                    return config;
                }
            }
            if (vendor == "VendorC")
            {
                var config = new Dictionary<string, string>();
                config.Add("base_price", "$15");
                config.Add("timeout", "30");
                if (env == "stage")
                {
                    // add env code
                    config.Add("database", "mongodb://stage.db.local:1111");
                    return config;
                }
                if (env == "prod")
                {
                    config.Add("database", "mongodb://prod.db.local:1111");
                    return config;
                }
                else
                {
                    config.Add("database", "mongodb://my.db.local:1111");
                    return config;
                }
            }

            return new Dictionary<string, string>();
        }
    }
}

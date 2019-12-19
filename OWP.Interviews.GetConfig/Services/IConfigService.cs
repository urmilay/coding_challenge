namespace OWP.Interviews.GetConfig.Services
{
    using System;
    using System.Collections.Generic;

    public interface IConfigService
    {
        Dictionary<string, string> GetConfig(string vendor, string env);
    }
}

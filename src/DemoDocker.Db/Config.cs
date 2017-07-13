using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDocker.Db
{
    public class Config
    {
        private static Dictionary<string, string> _Values = new Dictionary<string, string>();
        public static string ProductConnectionString { get { return Get("ProductContext"); } }

        private static string Get(string variable)
        {
            if (!_Values.ContainsKey(variable))
            {
                var value = Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Machine);
                if (string.IsNullOrEmpty(value))
                {
                    value = Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Process);
                }
                return value;
            }
            return ConfigurationManager.ConnectionStrings[variable].ConnectionString;
        }
    }
}

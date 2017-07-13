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
        public static string Path { get; set; }
        public static string ProductConnectionString { get { return Get("ProductContext"); } }

        private static string Get(string variable)
        {
            Path = "Get:";
            if (!_Values.ContainsKey(variable))
            {
                //var value = Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Machine);
                var environmentConnectionString = Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Machine);
                Path += ".  environmentConnectionString1 is:" +environmentConnectionString +Environment.NewLine;
                if (string.IsNullOrEmpty(environmentConnectionString))
                {
                    Path += ".  environmentConnectionString2 is:" + environmentConnectionString + Environment.NewLine;
                    environmentConnectionString = Environment.GetEnvironmentVariable(variable, EnvironmentVariableTarget.Process);
                }
                environmentConnectionString = !string.IsNullOrEmpty(environmentConnectionString)
                                        ? environmentConnectionString
                                        : ConfigurationManager.ConnectionStrings[variable].ConnectionString;
                Path += ".  environmentConnectionString3 is:" + environmentConnectionString + Environment.NewLine;
                return environmentConnectionString;
            }
            return ConfigurationManager.ConnectionStrings[variable].ConnectionString;
        }
    }
}

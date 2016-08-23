using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_config
{
    class Program
    {
        static void Main(string[] args)
        {
            string setting = ConfigurationManager.AppSettings["RefreshToken"];

            if (setting == null)

                setting = "Setting not found";

            Console.WriteLine(setting);   
        }
    }
}

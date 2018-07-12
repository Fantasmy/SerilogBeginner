using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerilogBeginner
{
    class Program
    {
            public static void Main(string[] args)
            {
            //using (var log = new LoggerConfiguration()
            //    .WriteTo.Console()
            //    .CreateLogger())
            //{
            //    log.Information("Hello, Serilog!");
            //    log.Warning("Goodbye, Serilog.");
            //}

            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();

            Log.Information("Hello again, Serilog!");

            Log.CloseAndFlush();
        }
        
    }
}

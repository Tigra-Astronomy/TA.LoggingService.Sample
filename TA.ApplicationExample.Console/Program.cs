
using Ninject;
using static System.Console;

namespace TA.ApplicationExample.Console
    {
    class Program
        {
        static void Main(string[] args)
            {
            WriteLine("Hello World!");
            // Note that the logging service is injected automatically by Ninject
            var applicationLogic = CompositionRoot.Kernel.Get<BusinessLogic>();
            applicationLogic.Run();
            }
        }
    }

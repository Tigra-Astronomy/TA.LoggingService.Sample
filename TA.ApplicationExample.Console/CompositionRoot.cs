using System;
using System.Collections.Generic;
using System.Text;
using Ascom.Utilities.Logging.LoggingService;
using Ninject;
using Ninject.Modules;
using TA.LoggingService.NLog;

namespace TA.ApplicationExample.Console
    {
    internal static class CompositionRoot
        {
        static CompositionRoot()
            {
            Kernel = new StandardKernel(new CoreModule());

            }

        public static IKernel Kernel { get; }
        }

    internal class CoreModule : NinjectModule
        {
        /// <inheritdoc />
        public override void Load()
            {
            Bind<ILog>().To<NLogLoggingService>().InTransientScope();
            }
        }
    }

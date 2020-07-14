using System;
using System.Collections.Generic;
using System.Text;
using Ascom.Utilities.Logging.LoggingService;

namespace TA.ApplicationExample.Console
    {
    class BusinessLogic
        {
        private readonly ILog log;

        public BusinessLogic(ILog log)
            {
            this.log = log;
            }

        internal void Run()
            {
            // The application "business logic" runs here.
            log.Trace().Message("Entering the method").Write();
            try
                {
                log.Info().Message("I've got a bad feeling about this...").Write();
                throw new Exception("Always the exception, never the rule");
                }
            catch (Exception e)
                {
                // Note: semantic logging.
                // This might render a "something" property/value tuple into the output.
                log.Error().Exception(e)
                    .Message("It threw when {something} happened", "a bad thing")
                    .Write();
                }
            finally
                {
                log.Trace().Message("leaving the method").Write();
                }
            }
        }
    }

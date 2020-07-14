// This file is part of the TA.LoggingService project
// Copyright © 2016-2020 Tigra Astronomy, all rights reserved.
// File: ILog.cs  Last modified: 2020-07-14@02:19 by Tim Long

using System.Runtime.CompilerServices;

namespace Ascom.Utilities.Logging.LoggingService
    {
    public interface ILog
        {
        IFluentLogBuilder Trace([CallerFilePath] string callerFilePath = null);

        IFluentLogBuilder Debug([CallerFilePath] string callerFilePath = null);

        IFluentLogBuilder Info([CallerFilePath] string callerFilePath = null);

        IFluentLogBuilder Warning([CallerFilePath] string callerFilePath = null);

        IFluentLogBuilder Error([CallerFilePath] string callerFilePath = null);

        IFluentLogBuilder Fatal([CallerFilePath] string callerFilePath = null);
        }
    }
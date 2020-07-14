using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Ascom.Utilities.Logging.LoggingService
    {
    public interface IFluentLogBuilder
        {
        IFluentLogBuilder Exception(Exception exception);

        IFluentLogBuilder LoggerName(string loggerName);

        IFluentLogBuilder Message(string message);

        IFluentLogBuilder Message(string format, params object[] args);

        IFluentLogBuilder Message(IFormatProvider provider, string format, params object[] args);

        IFluentLogBuilder Property(object name, object value);

        IFluentLogBuilder Properties(IDictionary properties);

        IFluentLogBuilder TimeStamp(DateTime timeStamp);

        IFluentLogBuilder StackTrace(StackTrace stackTrace, int userStackFrame);

        void Write([CallerMemberName]string callerMemberName=null, [CallerFilePath]string callerFilePath=null, [CallerLineNumber]int callerLineNumber=default);

        void WriteIf(Func<bool> condition, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = default);

        void WriteIf(bool condition, [CallerMemberName] string callerMemberName = null, [CallerFilePath] string callerFilePath = null, [CallerLineNumber] int callerLineNumber = default);
        }
    }
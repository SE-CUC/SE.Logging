using System;

namespace IngameScript
{
    public class EchoLogger : ILoggable
    {
        private readonly Action<string> _echoAction;

        public EchoLogger(Action<string> echoAction)
        {
            if (echoAction == null)
                throw new ArgumentNullException(nameof(echoAction));

            _echoAction = echoAction;
        }

        public void Clear() => _echoAction(string.Empty);

        public void Log(string message) => _echoAction(message);

        public void LogLine(string message) => _echoAction("\n" + message);
    }
}

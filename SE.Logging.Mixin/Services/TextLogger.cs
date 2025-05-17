using System;
using System.Collections.Generic;
using System.Text;

namespace IngameScript
{
    public class TextLogger : ILoggable
    {
        private readonly StringBuilder _builder = new StringBuilder(50,5000);

        public void Clear() => _builder.Clear();

        public void Log(string message) => _builder.Append(message);

        public void LogLine(string message) => _builder.AppendLine(message);

        public override string ToString() => _builder.ToString();
    }
}

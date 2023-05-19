using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaToolkit.Model
{
    [Serializable]
    public class FFmpegException : Exception
    {
        public int ExitCode;
        public List<string> MessageLog;

        public FFmpegException()
            : base() { }

        public FFmpegException(string message)
            : base(message) { }

        public FFmpegException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}

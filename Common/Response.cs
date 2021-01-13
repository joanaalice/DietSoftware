using System;

namespace Common
{
    public class Response
    {
        public string Message { get; set; }
        public bool Success { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }

    }
}

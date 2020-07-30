using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser
{
    public class StateCensusAnalyserException : Exception
    {
        public StateCensusAnalyserException()
        {

        }
        public enum ExceptionType
        {
            INVALID_PATH,
            INVALID_EXTENSION,
            DELIMITER_INCORRECT,
            HEADERS_MISSMATCH
        }
        public ExceptionType type;  

        public StateCensusAnalyserException(string message,ExceptionType type):base (message)
        {
            this.type = type;
        }

        public StateCensusAnalyserException(string message) : base(message)
        {
        }
    }
}

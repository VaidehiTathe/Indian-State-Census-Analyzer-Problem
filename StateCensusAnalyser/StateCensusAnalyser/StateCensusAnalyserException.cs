﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StateCensusAnalyser
{
    public class StateCensusAnalyserException : Exception
    {
        public enum ExceptionType
        {
            INVALID_PATH,
            INVALID_EXTENSION
        }
        public ExceptionType type;  

        public StateCensusAnalyserException(string message):base (message)
        {
           
        }
    }
}

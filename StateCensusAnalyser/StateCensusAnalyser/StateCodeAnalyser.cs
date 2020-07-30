using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public class StateCodeAnalyser
    {
        private readonly string filePath;
        public StateCodeAnalyser(string filePath)
        {
            this.filePath = filePath;

        }
        public static int GetStateCodeRecords(string filepath)
        {
            try
            {
                string[] numOfRecords = File.ReadAllLines(filepath);
                return numOfRecords.Length - 1;
            }
            catch (StateCensusAnalyserException)
            {
                throw new StateCensusAnalyserException("Enter correct directory path");
            }
            catch (FileNotFoundException)
            {
                throw new StateCensusAnalyserException("Enter correct directory path");
            }
        }
    }
}

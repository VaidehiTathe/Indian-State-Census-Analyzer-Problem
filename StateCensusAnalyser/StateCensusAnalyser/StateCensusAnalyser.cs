using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public class StateCensusAnalyser
    {
        private readonly string filePath;
        public StateCensusAnalyser(string filePath)
        {
            this.filePath = filePath;

        }
        public static int GetStateCensusRecords(string filepath)
        {
            try
            {               
                return CensusAnalyserUtility.GetRecords(filepath);            
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

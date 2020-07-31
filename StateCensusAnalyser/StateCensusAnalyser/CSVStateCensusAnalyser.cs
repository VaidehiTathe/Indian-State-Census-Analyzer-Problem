using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public class CSVStateCensusAnalyser
    {
        public static int GetRecords(string filePath)
        {
            try
            {
                int records = CensusAnalyserUtility.GetRecords(filePath);
                return records;
            }
            catch (StateCensusAnalyserException e)
            {
                throw new StateCensusAnalyserException(e.Message, e.type);
            }

        }

        public static void checkDelimiters(string filePath)
        {

            try
            {
                CensusAnalyserUtility.checkDelimiters(filePath);
            }
            catch (StateCensusAnalyserException e)
            {

                throw new StateCensusAnalyserException(e.Message, e.type);
            }
        }

        public static void HeaderException(string filePath, string alternateFilePath)
        {
            try
            {
                CensusAnalyserUtility.HeaderException(filePath);
            }
            catch (StateCensusAnalyserException e)
            {

                throw new StateCensusAnalyserException(e.Message, e.type);
            }
        }
    }       
}

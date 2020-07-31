using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    class CensusAnalyserUtility
    {
        public static int GetRecords(string filePath)
        {

            try
            {
                int countOfRecords = 0;
                string[] data = File.ReadAllLines(filePath);
                IEnumerable<string> records = data;
                List<string> dataList = new List<string>();
                foreach (var elements in records)
                {
                    countOfRecords++;
                    dataList.Add(elements);      
                }                             
                return dataList.Count - 1;
            }
            catch (DirectoryNotFoundException)
            {
                throw new StateCensusAnalyserException("Wrong directory path", StateCensusAnalyserException.ExceptionType.INVALID_PATH);
            }
            catch (FileNotFoundException)
            {
                throw new StateCensusAnalyserException("Incorrect file name", StateCensusAnalyserException.ExceptionType.INVALID_EXTENSION);
            }

        }
        internal int GetStateCensusRecords(string filepath)
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

        

        public static void checkDelimiters(string filePath)
        {
            string[] data = File.ReadAllLines(filePath);
            IEnumerable<string> records = data;
            foreach (var element in records)
            {
                if (element.Split() != element.Split(','))
                {
                    throw new StateCensusAnalyserException("Incorrect delimeter", StateCensusAnalyserException.ExceptionType.DELIMITER_INCORRECT);
                }
            }

        }

        public static void HeaderException(string filePath)
        {
            string alternateFilePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\data.csv";
            string[] data = File.ReadAllLines(filePath);
            string[] alternateData = File.ReadAllLines(alternateFilePath);
            if (data[0] != alternateData[0])
            {
                throw new StateCensusAnalyserException("Headers do not match", StateCensusAnalyserException.ExceptionType.HEADERS_MISSMATCH);
            }
        }

    }
}

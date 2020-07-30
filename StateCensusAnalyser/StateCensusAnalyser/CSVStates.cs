using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    public class CSVStates
    {
        public static int GetRecords(string filePath)
        {
            try
            {
                int countOfRecords = 0;
                String[] data = File.ReadAllLines(filePath);
                IEnumerable<string> records = data;
                foreach (var elements in records)
                {
                    countOfRecords++;
                }
                return countOfRecords - 1;
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


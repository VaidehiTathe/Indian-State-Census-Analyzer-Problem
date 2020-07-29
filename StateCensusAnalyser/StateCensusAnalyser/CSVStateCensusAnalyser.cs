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
                int countOfRecords = 0;
                string[] data = File.ReadAllLines(filePath);
                IEnumerable<string> records = data;
                foreach (var elements in records)
                {
                    countOfRecords++;
                }
                return countOfRecords - 1;
            }
            catch(StateCensusAnalyserException)
            {
                throw new StateCensusAnalyserException("Enter correct directory path");
            }

        }
        public static void HandleException(string filePath)
        {
            string alternateFilePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\data.csv";
            string FilePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.txt";
            if (filePath != FilePath)
            {
                throw new StateCensusAnalyserException("Extension is incorrect");
            }

            try 
            {
                string[] data = File.ReadAllLines(filePath);
                IEnumerable<string> records = data;
                foreach(var element in records)
                {
                    if (element.Split() != element.Split(','))
                    {
                        throw new StateCensusAnalyserException("Incorrect delimeter");
                    }
                }

                string[] alternateData = File.ReadAllLines(alternateFilePath);
                if(data[0] != alternateData[0])
                {
                    throw new StateCensusAnalyserException("Headers do not match");
                }
            }
            catch (StateCensusAnalyserException)
            {
                throw new StateCensusAnalyserException("Enter correct directory path");
            }
        }
    }
    
}

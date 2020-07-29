using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StateCensusAnalyser
{
    class CSVStateCensusAnalyser
    {
        public static int GetRecords(string filePath)
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
    }
    
}

using System;

namespace StateCensusAnalyser
{
    class CensusAnalyserMain
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.csv";
            int csvStateCensusRecords = CSVStateCensusAnalyser.GetRecords(filePath);
            int stateCensusRecords = StateCensusAnalyser.GetStateCensusRecords(filePath);
            Console.WriteLine("csv state census records:" + csvStateCensusRecords);
            Console.WriteLine("state census records:" + stateCensusRecords);
        }
    }
}

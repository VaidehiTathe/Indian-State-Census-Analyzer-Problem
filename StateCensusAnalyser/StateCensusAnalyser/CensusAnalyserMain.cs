using System;

namespace StateCensusAnalyser
{
    class CensusAnalyserMain
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.csv";
            string stateFilePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCode.csv";
            
            int csvStateCensusRecords = CSVStateCensusAnalyser.GetRecords(filePath);
            int stateCensusRecords = StateCensusAnalyser.GetStateCensusRecords(filePath);
            int csvStateCodeRecords = CSVStates.GetRecords(stateFilePath);
            int stateCodeRecords = StateCodeAnalyser.GetStateCodeRecords(stateFilePath);

            Console.WriteLine("csv state census records:" + csvStateCensusRecords);
            Console.WriteLine("state census records:" + stateCensusRecords);
            Console.WriteLine("csv state code records:" + csvStateCodeRecords);
            Console.WriteLine("state code records:" + stateCodeRecords);
        }
    }
}

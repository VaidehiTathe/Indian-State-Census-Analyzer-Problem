using NUnit.Framework;
using StateCensusAnalyser;

namespace CSVAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenCSVFile_WhenNumberOfRecordsMatches_ShoulReturnTrue()
        {
            string filePath = @"E:\CodinClub\Assignments_Fellowship\Census_Analyser_Problem\CensusAnalyser\CensusAnalyser\IndiaStateCensusData.csv";
            int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
            int records = StateCensusAnalyser.StateCensusAnalyser.GetStateCensusRecords(filePath);
            Assert.AreEqual(CSVRecords, records);
        }
    }
}
using NUnit.Framework;
using StateCensusAnalyser;

namespace CSVAnalyserTest
{
    public class Tests
    {
        [Test]
        public void GivenCSVFile_WhenNumberOfRecordsMatches_ShoulReturnTrue()
        {
            string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.csv";
            int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
            int records = StateCensusAnalyser.StateCensusAnalyser.GetStateCensusRecords(filePath);
            Assert.AreEqual(CSVRecords, records);
        }

        [Test]
        public void GivenCSVFilePath_WhenIncorrect_ShouldThrowCustomException()
        {
            try
            {
                string filePath = @"C:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.csv";
                int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
                int records = StateCensusAnalyser.StateCensusAnalyser.GetStateCensusRecords(filePath);
                Assert.AreEqual(CSVRecords, records);
            }
            catch (StateCensusAnalyserException e)
            {
                Assert.AreEqual(StateCensusAnalyserException.ExceptionType.INVALID_PATH, e.type);
            }

        }

        [Test]
        public void GivenCSVFileName_WhenIncorrectTypeOfFile_ShouldThrowCustomException()
        {
            try
            {
                string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.txt";
                int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
                int records = StateCensusAnalyser.StateCensusAnalyser.GetStateCensusRecords(filePath);
                Assert.AreEqual(CSVRecords, records);
            }
            catch (StateCensusAnalyserException e)
            {

                Assert.AreEqual(StateCensusAnalyserException.ExceptionType.INVALID_EXTENSION, e.type);
            }
        }


        [Test]
        public void GivenCSVFile_WhenIncorrectDelimiter_ShouldThrowCustomException()
        {
            try
            {
                string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.csv";
                int CSVRecords = CSVStateCensusAnalyser.GetRecords(filePath);
                int records = StateCensusAnalyser.StateCensusAnalyser.GetStateCensusRecords(filePath);
                Assert.AreEqual(CSVRecords, records);
            }
        
            catch (StateCensusAnalyserException e)
            {

                Assert.AreEqual(StateCensusAnalyserException.ExceptionType.DELIMITER_INCORRECT, e.type);
            }           
        }   


        [Test]
        public void GivenCSVFile_WhenHeadersDoNotMatch_ShouldThrowCustomException()
        {

            string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.csv";
            string alternateFilePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\data.csv";

            var exception = Assert.Throws<StateCensusAnalyserException>(() => CSVStateCensusAnalyser.HeaderException(filePath,alternateFilePath));
            Assert.AreEqual(StateCensusAnalyserException.ExceptionType.HEADERS_MISSMATCH, exception.type);

        }

        [Test]
        public void GivenCSVStateCodeFile_WhenNumberOfRecordsMatches_ShoulReturnTrue()
        {
            string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCode.csv";
            int CSVRecords = CSVStates.GetRecords(filePath);
            int records = StateCensusAnalyser.StateCodeAnalyser.GetStateCodeRecords(filePath);
            Assert.AreEqual(CSVRecords, records);
        }

        [Test]
        public void GivenCSVStateCodeFilePath_WhenIncorrect_ShouldThrowCustomException()
        {
            try
            {
                string filePath = @"C:\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCode.csv";
                int CSVRecords = CSVStates.GetRecords(filePath);
                int records = StateCensusAnalyser.StateCodeAnalyser.GetStateCodeRecords(filePath);
                Assert.AreEqual(CSVRecords, records);
            }
            catch (StateCensusAnalyserException e)
            {
                Assert.AreEqual(StateCensusAnalyserException.ExceptionType.INVALID_PATH, e.type);
            }

        }

        [Test]
        public void GivenCSVStateCodeFileName_WhenIncorrectTypeOfFile_ShouldThrowCustomException()
        {
            try
            {
                string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCode.txt";
                int CSVRecords = CSVStates.GetRecords(filePath);
                int records = StateCensusAnalyser.StateCodeAnalyser.GetStateCodeRecords(filePath);
                Assert.AreEqual(CSVRecords, records);
            }
            catch (StateCensusAnalyserException e)
            {

                Assert.AreEqual(StateCensusAnalyserException.ExceptionType.INVALID_EXTENSION, e.type);
            }
        }


        [Test]
        public void GivenCSVStateCodeFile_WhenIncorrectDelimiter_ShouldThrowCustomException()
        {

            string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCode.csv";
            var exception = Assert.Throws<StateCensusAnalyserException>(() => CSVStates.checkDelimiters(filePath));
            Assert.AreEqual(StateCensusAnalyserException.ExceptionType.DELIMITER_INCORRECT, exception.type);
        }

        [Test]
        public void GivenCSVSTateCodeFile_WhenHeadersDoNotMatch_ShouldThrowCustomException()
        {

            string filePath = @"E:\CodinClub\Assignments_Fellowship\Indian-State-Census-Analyzer-Problem\StateCensusAnalyser\StateCensusAnalyser\IndiaStateCensusData.csv";
            var exception = Assert.Throws<StateCensusAnalyserException>(() => CSVStates.HeaderException(filePath));
            Assert.AreEqual(StateCensusAnalyserException.ExceptionType.HEADERS_MISSMATCH, exception.type);

        }
    }
}
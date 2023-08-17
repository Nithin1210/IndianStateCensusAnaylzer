using IndianStateCensusAnaylzer;
namespace IndianStateCensusAnalyzerTest
{
    public class Tests
    {
        public string stateCensusDataFilePath2 = @"E:\BridgeLabz\IndianStateCensusAnaylzer\IndianStateCensusAnaylzer\Files\StateCensusDat.csv";
        public string stateCensusDataFilePath = @"E:\BridgeLabz\IndianStateCensusAnaylzer\IndianStateCensusAnaylzer\Files\StateCensusData.csv";

        [Test] 
        public void GivenStateCencusData_WhenAnalysed_RecordsShouldBeMAtched()
        {
            Assert.AreEqual(StateCensusAnalyser.ReadstateCensusData(stateCensusDataFilePath), CsvStateCensus.ReadStateCensusData(stateCensusDataFilePath));
            Assert.Pass();
        }
        [Test]
        public void GivenStateCencusDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadstateCensusData(stateCensusDataFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }

        }
        [Test]
        public void GivenStateCensusNoData_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadstateCensusData(stateCensusDataFilePath2);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "File Not Exist");
            }
        }
        [Test]
        public void GivenStateCensusHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadstateCensusData(stateCensusDataFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
    }
}
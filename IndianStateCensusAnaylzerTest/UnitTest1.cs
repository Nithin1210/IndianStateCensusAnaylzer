using IndianStateCensusAnaylzer;
namespace IndianStateCensusAnalyzerTest
{
    public class Tests
    {
        public string stateCensusDataFilePath = @"E:\BridgeLabz\IndianStateCensusAnaylzer\IndianStateCensusAnaylzer\Files\StateCensusData.csv";
        [Test]
        public void GivenStateCencusData_WhenAnalysed_RecordsShouldBeMAtched()
        {
            Assert.AreEqual(StateCensusAnalyser.ReadstateCensusData(stateCensusDataFilePath), CsvStateCensus.ReadStateCensusData(stateCensusDataFilePath));
            Assert.Pass();
        }
    }
}
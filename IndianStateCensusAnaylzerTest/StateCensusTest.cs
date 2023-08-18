using IndianStateCensusAnaylzer;
namespace IndianStateCensusAnalyzerTest
{
    public class Tests
    {
        public string stateCensusDataFilePath    = @"E:\BridgeLabz\IndianStateCensusAnaylzer\IndianStateCensusAnaylzer\Files\StateCensusData.csv";
        public string stateCensus_NODataFilePath = @"E:\BridgeLabz\IndianStateCensusAnay.csv";
        public string stateCencus_FileIncorrect  = @"C:\Users\TakkoliNithinKumarRe\Pictures\Screenshots\Screenshot 2023-08-12 121858.png";

        


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
                StateCensusAnalyser.ReadstateCensusData(stateCencus_FileIncorrect);
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
                StateCensusAnalyser.ReadstateCensusData(stateCensus_NODataFilePath);
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
        [Test]
        public void GivenStateDelimeterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCensusAnalyser.ReadstateCensusData(stateCensusDataFilePath);
            }
            catch (CensusAnalyserException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }
        
        
    }
}

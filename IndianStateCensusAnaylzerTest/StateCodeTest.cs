
using IndianStateCensusAnaylzer;

namespace IndianStateCensusAnaylzerTest
{
    public class StateCodeTest
    {
        public string stateCodeDataFilePath = @"E:\BridgeLabz\IndianStateCensusAnaylzer\IndianStateCensusAnaylzer\Files\StateCode.csv";
        public string stateCensus_NODataFilePath = @"E:\BridgeLabz\IndianStateCensusAnayl.csv";
        public string stateCencus_FileIncorrect = @"C:\Users\TakkoliNithinKumarRe\Pictures\Screenshots\Screenshot 2023-08-12 121858.png";



        [Test]
        public void GivenStateCodeData_WhenAnalysed_RecordsShouldBeMatched()
        {
            Assert.AreEqual(StateCodeAnalyser.ReadStateCodeData(stateCodeDataFilePath),CsvStateCode.ReadStateCodeData(stateCodeDataFilePath));
            Assert.Pass();
        }
        [Test]
        public void GivenStateCodeDataFileIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCencus_FileIncorrect);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "File extension incorrect");
            }

        }
        [Test]
        public void GivenStateCodeDataFileNotExists_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCensus_NODataFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "File not exists");
            }

        }
        [Test]
        public void GivenStateCodeHeaderIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Header Incorrect");
            }
        }
        [Test]
        public void GivenStateCodeDelimeterIncorrect_WhenAnalysed_ShouldReturnException()
        {
            try
            {
                StateCodeAnalyser.ReadStateCodeData(stateCodeDataFilePath);
            }
            catch (StateCodeException ex)
            {
                Assert.AreEqual(ex.Message, "Delimeter Incorrect");
            }
        }

    }
}

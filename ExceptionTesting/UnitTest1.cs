using RegexExceptionHandling;

namespace ExceptionTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenName_WhenValidate_ShouldReturnValid()
        {
            //Arrange
            string expectedResult = "Ritvik";
            UserRegistration test = new UserRegistration(expectedResult);

            //Act
            string result = test.ValidFirstName();

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        
        
    }
}
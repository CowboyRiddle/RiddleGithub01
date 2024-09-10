using CB_Basic_App_AzDev;
using Xunit;
namespace CB_Basic_App_Core.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            // Arrange
            Class1 tp = new Class1();
            // Act
            var result = tp.Name;
            // Assert
            Assert.Equal("[Firstname Lastname] - The Code Master", result);
        }
    }
}
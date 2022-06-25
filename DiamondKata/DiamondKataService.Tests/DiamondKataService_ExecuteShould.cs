using Xunit;
using DiamondKata.Services;

namespace DiamondKata.Services.Tests
{

    public class DiamondKataService_ExecuteShould
    {
        [Fact]
        public void Execute_InputA_ShouldReturnA()
        {
            var diamondKataService = new DiamondKataService();
            string result = diamondKataService.Execute("A");

            Assert.False(result!="A", "Answer should be A");
        }
    }
}
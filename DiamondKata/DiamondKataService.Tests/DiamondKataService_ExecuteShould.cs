using Xunit;
using DiamondKata.Services;

namespace DiamondKata.Services.Tests
{

    public class DiamondKataService_ExecuteShould
    {
        [Fact]
        public void PrintLine_InputC5_ShouldReturnC___C()
        {
            var diamondKataService = new DiamondKataService();
            string result = diamondKataService.PrintLine('C', 5);

            Assert.Equal("C   C", result);
        }
        [Fact]
        public void PrintLine_InputA5_ShouldReturn__A__()
        {
            var diamondKataService = new DiamondKataService();
            string result = diamondKataService.PrintLine('A', 5);

            Assert.Equal("  A  ", result);
        }

         [Fact]
         public void PrintLine_InputB5_ShouldReturn_B_B_()
        {
            var diamondKataService = new DiamondKataService();
            string result = diamondKataService.PrintLine('B', 5);

            Assert.Equal(" B B ", result);
        }

        [Theory]
        [InlineData('A', "A\n")]
        [InlineData('B', " A \nB B\n A \n")]
        [InlineData('C', "  A  \n B B \nC   C\n B B \n  A  \n")]
        public void Execute_ResultsInExpected(char character, string expectedResult){
            var diamondKataService = new DiamondKataService();
            var result = diamondKataService.Execute(character);

            Assert.Equal(expectedResult, result);
        }
    }
}
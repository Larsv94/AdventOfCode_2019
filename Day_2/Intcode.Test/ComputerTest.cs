using System.Linq;
using Xunit;

namespace Intcode.Test
{
    public class ComputerTest
    {
        //[InlineData(new int[]{1,1,2,0},new int[]{3,1,2,0})]
        //[InlineData(new int[]{1,9,10,3,2,3,11,0,99,30,40,50},new int[]{3500,9,10,70,2,3,11,0,99,30,40,50})]

        [Theory]
        [InlineData(new int[]{1,1,2,0},3)]
        [InlineData(new int[]{1,9,10,3,2,3,11,0,99,30,40,50},3500)]
        public void Run_OutputEquals_ExpectedValue(int[] input, int expectedValue){
            Computer computer = new Computer(input);
            var output = computer.Process();
            Assert.Equal(expectedValue,output);
        }
    }
}
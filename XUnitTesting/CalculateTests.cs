using PipelineLibrary;

namespace XUnitTesting
{
    public class CalculateTests
    {
        [Fact]
        public void AddSumCorrect()
        {
            int left = 5;
            int right = 5;
            int result = Calculator.Add(left, right);
            Assert.Equal(left + right, result);
        }

        [Fact]
        public void SubstractDiffCorrect()
        {
            int left = 5;
            int right = 5;
            int result = Calculator.Substract(left, right);
            Assert.Equal(left - right, result);
        }
    }
}
using NUnit.Framework;

namespace Interviews.Rustin
{
    [TestFixture]
    public class FizzBuzzProcessorTests
    {
        [Test]
        public void given_multiple_of_three_return_fizz()
        {
            const string expectedValue = "fizz";

            var processor = new FizzBuzzProcessor();
            var valueFor3 = processor.Process(3);
            valueFor3.Should.Be(expectedValue);
            
            var valueFor12 = processor.Process(12);
            valueFor12.Should.Be(expectedValue);
        }
    }
}

using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ShouldRespondWithNumberWhenGivenNumberThatIsNeitherAMultipleOfThreeOrFive()
        {
            var sut = new FizzBuzz();
            sut.FormulateResponse(1);

            Assert.That(sut.Response, Is.EqualTo("1"));

        }

        [Test]
        public void ShouldRespondWithFizzWhenGivenNumberThatIsMutlipleOfThree()
        {
            var sut = new FizzBuzz();
            sut.FormulateResponse(3);

            Assert.That(sut.Response, Is.EqualTo("Fizz"));

        }

        [Test]
        public void ShouldRespondWithBuzzWhenGivenThatIsAMutlipleOfFive()
        {
            var sut = new FizzBuzz();
            sut.FormulateResponse(5);

            Assert.That(sut.Response, Is.EqualTo("Buzz"));

        }

        [Test]
        public void ShouldRespondWithFizzBuzzWhenGivenMutlipleOfThreeAndFive()
        {
            var sut = new FizzBuzz();
            sut.FormulateResponse(15);

            Assert.That(sut.Response, Is.EqualTo("FizzBuzz"));

        }

    }
}

using KataFizzBuzz;
using NUnit.Framework;
using Moq;
using System.Collections.Generic;

namespace TestProjectFizzBuzz
{
    public class Tests
    {
        IFizzBuzzCounter _sut;
        [SetUp]
        public void Setup()
        {
            var mock = new Mock<IFileReader>();
            mock.Setup(x => x.ReadNumberFromFile(It.IsAny<string>())).Returns(1);
            var _sutReader = mock.Object;
            _sut = new FizzBuzzCounter(_sutReader);
        }
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(3, ExpectedResult = "Fizz")]
        [TestCase(4, ExpectedResult = "4")]
        [TestCase(5, ExpectedResult = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz")]
        public string TestFizzBuzz(int input) => _sut.Translate(input);

        [Test]
        public void TestFizzBuzzCounter()
        {
            var expected = new List<string> { "1", "2", "Fizz" }; //continuous until your input number... o try to make a new test
            var actual = _sut.Counter(3);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestCounterFromFile()
        {
            var actual = _sut.CounterFromFile("test");
            Assert.AreEqual(new List<string> { "1" }, actual);
        }
    }
}
using Moq;
using NUnit.Framework;
using Orchid.Core.Enumerations;
using Orchid.Core.Services;
using RandomNameGeneratorLibrary;

namespace Orchid.Core.Tests
{
    public class NameGeneratorTests
    {
        private const string FemaleName = "FEMALE";
        private const string MaleName = "MALE";

        private NameGenerator sut;


        [SetUp]
        public void Setup()
        {
            var mockPersonNameGenerator = new Mock<IPersonNameGenerator>();

            mockPersonNameGenerator.Setup(x => x.GenerateRandomFemaleFirstName()).Returns(FemaleName);
            mockPersonNameGenerator.Setup(x => x.GenerateRandomMaleFirstName()).Returns(MaleName);

            this.sut = new NameGenerator(mockPersonNameGenerator.Object);
        }

        [Test]
        public void WhenGeneratingFemaleFirstNameReturnFemaleFirstName()
        {
            Assert.AreEqual(FemaleName, this.sut.GenerateFirstName(Gender.Female));
        }

        [Test]
        public void WhenGeneratingMaleFirstNameReturnMaleFirstName()
        {
            Assert.AreEqual(MaleName, this.sut.GenerateFirstName(Gender.Male));
        }
    }
}
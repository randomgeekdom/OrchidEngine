using Orchid.Core.Enumerations;
using Orchid.Core.Interfaces;
using RandomNameGeneratorLibrary;

namespace Orchid.Core.Services
{
    public class NameGenerator : INameGenerator
    {
        private readonly IPersonNameGenerator personNameGenerator;

        public NameGenerator(IPersonNameGenerator personNameGenerator)
        {
            this.personNameGenerator = personNameGenerator;
        }

        public string GenerateFirstName(Gender gender)
        {
            return gender == Gender.Male ? this.personNameGenerator.GenerateRandomMaleFirstName() : this.personNameGenerator.GenerateRandomFemaleFirstName();
        }

        public string GenerateLastName()
        {
            return this.personNameGenerator.GenerateRandomLastName();
        }
    }
}
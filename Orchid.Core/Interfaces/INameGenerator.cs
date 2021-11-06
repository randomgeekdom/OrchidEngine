using Orchid.Core.Enumerations;

namespace Orchid.Core.Interfaces
{
    public interface INameGenerator
    {
        string GenerateFirstName(Gender gender);
        string GenerateLastName();
    }
}

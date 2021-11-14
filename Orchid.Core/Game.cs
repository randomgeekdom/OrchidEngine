using OrchidCavalry.ViewModels;

namespace Orchid.Engine.Core
{
    public abstract class Game
    {
        public Scenario StartingScenario { get; }

        public IEnumerable<StatSection> StatSections { get; }
    }
}

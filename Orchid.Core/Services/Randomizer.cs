using Orchid.Core.Interfaces;

namespace Orchid.Core.Services
{
    public class Randomizer : IRandomizer
    {
        private readonly Random random = new();
        public bool GetBool(int percentage = 50)
        {
            return this.random.Next(100) < percentage;
        }
    }
}

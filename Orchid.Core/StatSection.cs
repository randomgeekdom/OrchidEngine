namespace Orchid.Engine.Core
{
    public class StatSection
    {
        public string Name { get; set; }
        public IEnumerable<IStat> Stats { get; set; }
    }
}

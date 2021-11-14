namespace Orchid.Engine.Core
{
    public abstract class Stat<T> : IStat
    {
        public string Name { get; set; }
        public T Value { get; set; }

        public string? DisplayValue => Value?.ToString();
    }
}

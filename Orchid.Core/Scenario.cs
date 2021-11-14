namespace OrchidCavalry.ViewModels
{
    public class Scenario
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public Dictionary<string, Func<Scenario>> Options { get; set; } = new Dictionary<string, Func<Scenario>>();
    }
}

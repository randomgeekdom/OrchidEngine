using System;
using System.Collections.Generic;

namespace OrchidCavalry.ViewModels
{
    public class MainViewModel
    {
        private readonly Selection selection = new Selection();
        public string Title => this.selection.Title;
        public string Body => this.selection.Body;

        public Dictionary<string, Func<Selection>> Options => this.selection.Options;
    }

    public class Selection
    {
        public string Title { get; set; } = "This is the title";
        public string Body { get; set; } = "There is more to life than this";

        public Dictionary<string, Func<Selection>> Options { get; set; } = new Dictionary<string, Func<Selection>> {
            {"hello", ()=>null },
            {"goodbye", ()=>null },
        };
    }
}

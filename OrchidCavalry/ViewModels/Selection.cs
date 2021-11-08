using System;
using System.Collections.Generic;

namespace OrchidCavalry.ViewModels
{
    public class Selection
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public Dictionary<string, Func<Selection>> Options { get; set; } = new Dictionary<string, Func<Selection>>();
    }
}

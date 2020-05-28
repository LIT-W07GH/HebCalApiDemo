using System.Collections.Generic;

namespace HebCalReactDemo.Api
{
    public class ShabbosTimesResult
    {
        public string Title { get; set; }
        public Location Location { get; set; }
        public IEnumerable<Event> Items { get; set; }
    }
}
using Newtonsoft.Json;

namespace HebCalReactDemo.Api
{
    public class HebCalConversionResult
    {
        [JsonProperty("hm")]
        public string HebrewMonth { get; set; }

        [JsonProperty("hd")]
        public int HebrewDay { get; set; }

        [JsonProperty("hy")]
        public int HebrewYear { get; set; }
        public string Hebrew { get; set; }
        public string[] Events { get; set; }
    }
}
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AlexaSkillsKit.Slu
{
    public class ResolutionPerAuthority
    {
        [JsonProperty("authority")]
        public string Authority { get; set; }

        [JsonProperty("status")]
        public ResolutionStatus Status { get; set; }

        [JsonProperty("values")]
        public List<ResolutionValueEntry> Values { get; set; }
    }
}
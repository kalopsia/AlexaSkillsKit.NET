using Newtonsoft.Json;

namespace AlexaSkillsKit.Slu
{
    public class ResolutionValue
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
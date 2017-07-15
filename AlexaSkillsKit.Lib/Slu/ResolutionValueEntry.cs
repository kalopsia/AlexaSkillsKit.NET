using Newtonsoft.Json;

namespace AlexaSkillsKit.Slu
{
    public class ResolutionValueEntry
    {
        [JsonProperty("value")]
        public ResolutionValue Value { get; set; }
    }
}
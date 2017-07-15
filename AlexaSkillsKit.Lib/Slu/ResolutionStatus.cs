using Newtonsoft.Json;

namespace AlexaSkillsKit.Slu
{
    public class ResolutionStatus
    {
        [JsonProperty("code")]
        public ResolutionStatusCode Code { get; set; }
    }
}
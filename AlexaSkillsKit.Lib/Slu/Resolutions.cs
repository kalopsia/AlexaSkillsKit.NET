using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlexaSkillsKit.Slu
{
    public class Resolutions
    {
        [JsonProperty("resolutionsPerAuthority")]
        public List<ResolutionPerAuthority> ResolutionsPerAuthority { get; set; }
    }
}

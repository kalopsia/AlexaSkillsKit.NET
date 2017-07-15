//  Copyright 2015 Stefan Negritoiu (FreeBusy). See LICENSE file for more information.

using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AlexaSkillsKit.Slu
{
    public class Slot
    {
        [JsonProperty("name")]
        public virtual string Name { get; set; }

        [JsonProperty("value")]
        public virtual string Value { get; set; }

        [JsonProperty("resolutions")]
        public virtual Resolutions Resolutions { get; set; }
    }
}
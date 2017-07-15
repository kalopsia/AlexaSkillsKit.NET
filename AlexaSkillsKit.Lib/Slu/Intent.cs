//  Copyright 2015 Stefan Negritoiu (FreeBusy). See LICENSE file for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AlexaSkillsKit.Slu
{
    public class Intent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static Intent FromJson(JObject json) {

            var slots = json["slots"] != null
                ? JsonConvert.DeserializeObject<Dictionary<string, Slot>>(json["slots"].ToString())
                : new Dictionary<string, Slot>();

            return new Intent {
                Name = json.Value<string>("name"),
                Slots = slots
            };
        }

        public virtual string Name {
            get;
            set;
        }

        public virtual Dictionary<string, Slot> Slots {
            get;
            set;
        }
    }
}
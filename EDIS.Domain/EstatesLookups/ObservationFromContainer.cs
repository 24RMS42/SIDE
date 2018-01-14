﻿using EDIS.Domain.Base;
using EDIS.Domain.Estates;
using Newtonsoft.Json;
using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace EDIS.Domain.EstatesLookups
{
    public class ObservationFromContainer : BaseEntity
    {
        [JsonProperty("tbl_observation_from")]
        public List<ObservationFrom> ObservationFromItems { get; set; }

        
    }
}

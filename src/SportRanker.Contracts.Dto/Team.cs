﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SportRanker.Contracts.Dto
{
    [DataContract]
    public class Team
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public long SportId { get; set; }

        [DataMember]
        public string SportName { get; set; }

        [DataMember]
        public long StateId { get; set; }

        [DataMember]
        public string StateName { get; set; }

        [DataMember]
        public long CityId { get; set; }

        [DataMember]
        public string CityName { get; set; }

        [DataMember]
        public long Rating { get; set; }

        [DataMember]
        public ICollection<ExternalMapping> ExternalMappings { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }
    }
}

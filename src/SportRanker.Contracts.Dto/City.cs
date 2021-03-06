﻿using System.Runtime.Serialization;

namespace SportRanker.Contracts.Dto
{
    [DataContract]
    public class City
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public long Rating { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }
    }
}

using SportRanker.Contracts.Dto;
using System.Runtime.Serialization;

namespace SportRanker.Contracts.SystemEvents
{
    [DataContract]
    public class RankingChange
    {
        [DataMember]
        public SportId SportId { get; set; }

        [DataMember]
        public long TeamId { get; set; }

        [DataMember]
        public long Ranking { get; set; }

        [DataMember]
        public RankingChangeType RankingChangeType { get; set; }
    }
}

using SportRanker.Contracts.Dto;
using System.Runtime.Serialization;

namespace SportRanker.Contracts.SystemEvents
{
    [DataContract]
    public class RankingChange
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public long Ranking { get; set; }

        [DataMember]
        public RankingChangeType RankingChangeType { get; set; }
    }
}

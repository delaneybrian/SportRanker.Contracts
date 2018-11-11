using System.Runtime.Serialization;

namespace SportRanker.Contracts.Dto
{
    [DataContract]
    public class ExternalMapping
    {
        [DataMember]
        public SourceId Source { get; set; }

        [DataMember]
        public string SourceId { get; set; }
    }
}

using System.Runtime.Serialization;

namespace SportRanker.Contracts.Dto
{
    [DataContract]
    public class Sport
    {
        [DataMember]
        public long SportId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string SportName { get; set; }

        [DataMember]
        public string ImageUrl { get; set; }
    }
}

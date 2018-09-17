using System.Runtime.Serialization;

namespace JsonApp
{
    [DataContract]
    class User
    {
        [DataMember(Name = "userId")]
        public string UserId { set; get; }
        [DataMember(Name = "id")]
        public string Id { set; get; }
        [DataMember(Name = "title")]
        public string Title { set; get; }
        [DataMember(Name = "completed")]
        public bool Completed { set; get; }
    }
}

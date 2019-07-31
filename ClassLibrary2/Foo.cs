using System.Runtime.Serialization;

namespace ClassLibrary2
{
    [DataContract]
    public class Foo
    {
        [DataMember]
        public int Id { get; set; }
    }
}

using System.Xml.Serialization;


[XmlRoot("UserListResult")]
public class UserListResult2
{
    [XmlElement("Code", Namespace = "http://schemas.datacontract.org/2004/07/Data")]
    public string Code { get; set; }
    [XmlElement("Message", Namespace = "http://schemas.datacontract.org/2004/07/Data")]
    public string Message { get; set; }
    [XmlArray("Users", Namespace = "http://schemas.datacontract.org/2004/07/Data"), XmlArrayItem("User", Namespace = "http://schemas.datacontract.org/2004/07/Data")]
    public User2[] Users { get; set; }
}


public class User2
{
    [XmlElement("Id", Namespace = "http://schemas.datacontract.org/2004/07/Data")]
    public int Id { get; set; }
    [XmlElement("Name", Namespace = "http://schemas.datacontract.org/2004/07/Data")]
    public string Name { get; set; }
    [XmlElement("Type", Namespace = "http://schemas.datacontract.org/2004/07/Data")]
    public string Type { get; set; }

}




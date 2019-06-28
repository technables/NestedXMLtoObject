using System.Xml.Serialization;


[XmlRoot("UserListResult")]
public class UserListResult
{
    [XmlElement("Code")]
    public string Code { get; set; }
    [XmlElement("Message")]
    public string Message { get; set; }
    [XmlArray("Users"), XmlArrayItem("User")]
    public User[] Users { get; set; }
}

public class User
{
    [XmlElement("Id")]
    public int Id { get; set; }
    [XmlElement("Name")]
    public string Name { get; set; }
    [XmlElement("Type")]
    public string Type { get; set; }

}


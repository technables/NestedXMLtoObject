using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace XMLtoObject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string filePath = Directory.GetCurrentDirectory() + @"\userxml.xml";
            string usersXML = File.ReadAllText(filePath);
            UserListResult userList = DeserializeXMLtoObject<UserListResult>(usersXML);

            string filePath2 = Directory.GetCurrentDirectory() + @"\userxml2.xml";
            string usersXML2 = File.ReadAllText(filePath);
            UserListResult2 userList2 = DeserializeXMLtoObject<UserListResult2>(usersXML);
        }


        public T DeserializeXMLtoObject<T>(string xmlString) where T : class
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));

            using (StringReader sr = new StringReader(xmlString))
            {
                return (T)ser.Deserialize(sr);
            }
        }
    }
}

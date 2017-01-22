using System;
using System.IO;
using System.Xml.Serialization;

namespace StringWriter
{
    public class IPData
    {
        public static XmlSerializer sr = new XmlSerializer(typeof(IPData));
        public static IPData Data;
        public string address;

        public static void savIP(string str)
        {
            File.Delete("data.xml");

            Data.address = str;
            TextWriter writer = new StreamWriter("data.xml");

            sr.Serialize(writer, Data);
            writer.Close();
        }

        public static string loadIP()
        {
            if (!File.Exists("data.xml"))
            {
                Data = new IPData();
                Data.address = "192.168.1.1";
            }
            else
            {
                try
                {
                    using (FileStream stream = File.OpenRead("data.xml"))
                    {
                        Data = (IPData)sr.Deserialize(stream);

                    }
                }
                catch (Exception)
                {
                    Data = new IPData();
                    Data.address = "192.168.1.1";
                }
            }
            return Data.address;

        }

    }
}

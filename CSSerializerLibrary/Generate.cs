using CSAc4yClass.Class;
using GuidLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CSSerializerLibrary
{
    public class Generate
    {
        public static void SerializeClasses(Type anyType, string PATH)
        {
            string _guidValue = "";
            try
            {
                GUID _guid = (GUID)anyType.GetCustomAttributes(typeof(GUID), true).First();
                _guidValue = _guid.getGuid();
            }
            catch (Exception _exception)
            {

            }
            PropertyInfo[] _propInf = anyType.GetProperties();

            Ac4yClass _ac4yClass1 = new Ac4yClass(anyType.Name);
            _ac4yClass1.Namespace = anyType.Namespace;
            _ac4yClass1.Ancestor = anyType.BaseType.Name;
            _ac4yClass1.GUID = _guidValue;
            foreach (var _prop in _propInf)
            {
                _ac4yClass1.PropertyList.Add(new Ac4yProperty(_prop.Name, _prop.PropertyType.Name));
            }
            SerializeAsXml2TextFile(_ac4yClass1.GetType(), _ac4yClass1, _ac4yClass1.Name, PATH);
        }
        static void SerializeAsXml2TextFile(Type aType, Object aObject, String aObjectName, String aPath)
        {
            XmlSerializer _xmlSerializer = new XmlSerializer(aType);
            TextWriter _textWriter = new StreamWriter(aPath + aObjectName + "@" + aType.Name + ".xml");
            _xmlSerializer.Serialize(_textWriter, aObject);
            _textWriter.Close();
        }

    }
}

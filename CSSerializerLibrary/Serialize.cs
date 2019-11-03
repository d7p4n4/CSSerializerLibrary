using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSerializerLibrary
{
    public class Serialize
    {
        //2019. 10. 24. 15:55

        public void SerializeMethod(string path, Type _anyType)
        {
            Generate _generate = new Generate();

            System.Reflection.Assembly a = System.Reflection.Assembly.Load(_anyType.Namespace);
            var allTypes = a.GetTypes();

            foreach (var type in allTypes)
            {
                _generate.SerializeClasses(type, path);
            }
        }
    }
}

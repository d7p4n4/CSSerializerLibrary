using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSerializerLibrary
{
    public class Program
    {
        //2019. 10. 24. 11:52

        public const string PATH = "d:\\Server\\Visual_studio\\";

        static void Main(string[] args)
        {
            Generate.SerializeClasses(typeof(Student), PATH);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace CSSerializerLibrary
{
    //[GUID()]
    class Student
    {
        public int id { get; set; }
        public string GUID { get; set; }
        public int age { get; set; }
        public string name { get; set; }
        public string address { get; set; }

    }
}

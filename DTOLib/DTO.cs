﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DTOLib
{
    [Serializable]
    public abstract class DTO
    {
    }
    [Serializable]
    public class DTO1 : DTO
    {
        public int intField;
        public float floatField;
        public byte byteField;
        public char charField;
        protected int protectedField;
        public int Property { get; }
        public DateTime dat;
        public string str;
        public int[] array;
        public DTO2 dto2;

        public DTO1() { }

        public DTO1(int a)
        {
            protectedField = a;
        }
    }
    [Serializable]
    public class DTO2 : DTO
    {
        public DTO1 dto1;
        public bool BoolProperty { get; set; }
        public Enum UnsuppotredType;
    }
}

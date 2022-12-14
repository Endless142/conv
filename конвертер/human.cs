using System;
using System.Collections.Generic;

namespace конвертер
{
    public class human
    {
        public static string name;
        public static int age;
        public static string color;
        public List<human> humans;

        public human()
        { }

        public human(string korobkaname, int korobkaage, string korobkacolor)
        {
            name = korobkaname;
            age = korobkaage;
            color = korobkacolor;
        }
    }
}
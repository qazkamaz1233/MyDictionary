using System;
using System.Collections.Generic;


namespace examen.MyDictionary
{
    public class MyDictionary
    {
        public static string Name { get; set; }
        public static List<string> translationList { get; set; } = new List<string>();
        public static Dictionary<string, List<string>> Dic { get; set; } = new Dictionary<string, List<string>>();

    }
}

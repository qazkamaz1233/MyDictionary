using examen.Menus;
using Newtonsoft.Json;
using System;
using System.IO;


namespace examen.MyDictionary.Comands
{
    internal class SerrialaizdDic : MyDictionary, ICommand<string>
    {
        public string Description => "Сохранить";
        public void Execute()
        {
            File.WriteAllText(Name + ".json", JsonConvert.SerializeObject(Dic));

            Console.WriteLine("Файл сохранен!");
            Console.ReadKey();
        }
    }
}


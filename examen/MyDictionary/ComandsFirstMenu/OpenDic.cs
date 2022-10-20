using examen.Menus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using examen.Menues;
using examen.MyDictionary.Comands;
using Newtonsoft.Json;

namespace examen.MyDictionary.ComandsFirstMenu
{
    internal class OpenDic : MyDictionary, ICommand<string>
    {
        public string Description => "Открыть словарь";

        private void OpenSave(string name)
        {
            var path = new StringBuilder(Directory.GetCurrentDirectory().ToString()).Append($"\\{name}.json").ToString();
            Dic = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(File.ReadAllText(path));
        }
        public void Execute()
        {
            Console.WriteLine("Название словаря");
            Name = Console.ReadLine();

            if (File.Exists(Name + ".json"))
            {
                OpenSave(Name);
                var mainMenu = new Menu<string>(new AddWords(), new DelTranslation(),
                    new DelWord(), new PrintDic(), new ReplaceTranslation(),
                    new ReplaceWord(), new SearchTranslate(), new SerrialaizdDic());

                mainMenu.Start();
            }
        }
    }
}

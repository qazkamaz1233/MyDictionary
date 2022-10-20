using System;
using System.IO;
using System.Reflection;
using examen.Menues;
using examen.Menus;
using examen.MyDictionary.Comands;

namespace examen.MyDictionary.ComandsFirstMenu
{
    internal class CreateDic : MyDictionary, ICommand<string>
    {
        public string Description => "Создать словарь";

        public void Execute()
        {
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Console.WriteLine("Имя нового словаря");
            Name = Console.ReadLine();

            var pathLocalDir = Directory.GetCurrentDirectory();
         
            if (File.Exists(pathLocalDir + Name + ".json"))
            {
                Console.WriteLine("Словарь с таким именем существует");
                return;
            }
            var mainMenu = new Menu<string>(new AddWords(), new DelTranslation(),
                                new DelWord(), new PrintDic(), new ReplaceTranslation(),
                                new ReplaceWord(), new SearchTranslate(), new SerrialaizdDic());

            mainMenu.Start();


        }

    }
}

using System;
using System.Linq;
using examen.Menus;

namespace examen.MyDictionary.Comands
{
    internal class ReplaceTranslation : MyDictionary, ICommand<string>
    {
        public string Description => "Замена перевода";
        public void Execute()
        {
            Console.WriteLine("Введите слово для замены перевода: ");
            string SearchWord = Console.ReadLine();

            Console.WriteLine("Введите перевод слова: ");
            var wordRepl = Console.ReadLine().Split().ToList();

            if (Dic.TryGetValue(SearchWord, out _))
                Dic[SearchWord] = wordRepl;
            else
                Console.WriteLine("Слово не найдено.");
        }

    }
}

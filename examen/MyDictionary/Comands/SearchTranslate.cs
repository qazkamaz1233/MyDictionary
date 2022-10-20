using examen.Menus;
using System;

namespace examen.MyDictionary.Comands
{
    internal class SearchTranslate : MyDictionary, ICommand<string>
    {
        public string Description => "Поиск слова";
        public void Execute()
        {
            Console.WriteLine("Введите слово для поиска перевода: ");
            string searchWord = Console.ReadLine();
            if (!Dic.ContainsKey(searchWord))
            {
                Console.WriteLine("Слово не найдено");
                return;
            }
            else
            {
                var listTranslate = Dic[searchWord];
                Console.WriteLine("Перевод: ");
                listTranslate.ForEach(Console.WriteLine);
            }
        }
    }
}

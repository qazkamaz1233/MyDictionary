using System;
using System.Collections.Generic;
using System.Linq;
using examen.Menus;

namespace examen.MyDictionary.Comands
{
    internal class AddWords : MyDictionary, ICommand<string>
    { 
        public string Description => "Добавить слово";
        public void Execute()
        {
            Console.WriteLine("Слово: ");
            string word = Console.ReadLine();
            Console.WriteLine("Перевод: ");
            string translation = Console.ReadLine();
            foreach (var item in translation.Split())
                translationList.Add(item);

            if (!Dic.ContainsKey(word.Trim()))
            {
                translationList.RemoveAll(x => x == "");
                Dic.Add(word, new List<string>(translationList));
                translationList.Clear();
            }
            else
            {
                foreach (var value in translationList)
                    Dic[word].Add(value.Trim());

                translationList.Clear();
            }
            var temp = Dic[word].Distinct().ToList();
            Dic[word] = temp;

        }
    }
}

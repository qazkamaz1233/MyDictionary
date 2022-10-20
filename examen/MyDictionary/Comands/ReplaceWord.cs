using System;
using System.Collections.Generic;
using examen.Menus;


namespace examen.MyDictionary.Comands
{
    internal class ReplaceWord : MyDictionary, ICommand<string>
    {
        public string Description => "Замена слова";
        private static void RenameKey<TKey, TValue>(IDictionary<TKey, TValue> dic, TKey fromKey, TKey toKey)
        {
            TValue value = dic[fromKey];
            dic.Remove(fromKey);
            dic[toKey] = value;
        }
        public void Execute()
        {
            Console.WriteLine("Какое слово нужно заменить: ");
            string searchWord = Console.ReadLine();

            Console.WriteLine("Новое значение: ");
            string newhWord = Console.ReadLine();
            if (Dic.TryGetValue(searchWord, out _))
                RenameKey(Dic, searchWord, newhWord.Trim());
            else
                Console.WriteLine("Слово не найдено");
        }
    }
}

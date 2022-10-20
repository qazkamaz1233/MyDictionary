using System;
using examen.Menus;



namespace examen.MyDictionary.Comands
{
    internal class DelTranslation : MyDictionary, ICommand<string>
    {
        public string Description => "Удалить перевод";
        public void Execute()
        {
            Console.WriteLine("Введите слово, перевод которого нужно удалить: ");
            string searchWord = Console.ReadLine();
            Console.WriteLine("Удаляемый перевод: ");
            var newhWord = Console.ReadLine().Split(',', '.', ' ');
            if (Dic.ContainsKey(searchWord))
            {
                for (int i = 0; i < Dic[searchWord].Count; i++)
                {
                    for (int j = 0; j < newhWord.Length; j++)
                        if (Dic[searchWord][i] == newhWord[j] && Dic[searchWord].Count != 1)
                            Dic[searchWord].RemoveAt(i);
                }
            }
            else
            {
                Console.WriteLine("Слово не найдено!");
            }
        }
    }
}

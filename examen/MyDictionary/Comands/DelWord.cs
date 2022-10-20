using examen.Menus;
using System;


namespace examen.MyDictionary.Comands
{
    internal class DelWord : MyDictionary, ICommand<string>
    {
        public string Description => "Удалить слово";
        public void Execute()
        {
            Console.WriteLine("Введите слово для удаления: ");
            string searchWord = Console.ReadLine();

            Dic.Remove(searchWord);
        }
    }
}

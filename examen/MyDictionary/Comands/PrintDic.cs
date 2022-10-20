using System;
using examen.Menus;


namespace examen.MyDictionary.Comands
{
    internal class PrintDic : MyDictionary, ICommand<string>
    {
        public string Description => "Вывод на экран";
        public void Execute()
        {
            foreach (var VARIABLE in Dic)
            {
                Console.Write($"{VARIABLE.Key} : ");
                Console.WriteLine(String.Join(", ", VARIABLE.Value));
            }

            Console.ReadKey();
        }

    }
}

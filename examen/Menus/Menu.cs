using System;
using System.Linq;
using examen.Menus;

namespace examen.Menues
{
    public class Menu<TValue>
    {
        protected string BackCommandDescription => "Выход";

        private readonly ICommand<TValue>[] commands;
        
        public Menu(params ICommand<TValue>[] commands)
        {
            this.commands = commands;
        }
        public void Start()
        {
            while (true)
            {
                Console.Clear();
                PrintCommands();

                var selector = ConsoleReadHelper.ReadInt(" => ", 0, commands.Length);
                if (selector == 0)
                    break;

                ExecuteCommand(selector - 1);
            }
        }
        protected virtual void PrintCommands()
        {
            commands
                .Select((command, i) => $"{i + 1}: {command.Description}")
                .Concat($"0: {BackCommandDescription}".AsEnumerable())
                .ForEach(Console.WriteLine);
        }
        private void ExecuteCommand(int selector)
        {
            commands[selector].Execute();
        }
    }
}

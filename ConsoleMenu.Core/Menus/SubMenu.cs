using examen.Menues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen.Menus
{
    public class SubMenu<TValue> : Menu<TValue>
    {
        protected override string BackCommandDescription => "Выход";

        public string MenuDescription { get; }

        public SubMenu(string menuDescription, params ICommand<TValue>[] commands) : this(menuDescription, default(TValue), commands)
        {
        }
        public SubMenu(string menuDescription, TValue value, params ICommand<TValue>[] commands) : this(menuDescription, new ValueWrapper<TValue> { Value = value }, commands)
        {
        }
        public SubMenu(string menuDescription, ValueWrapper<TValue> wrapper, params ICommand<TValue>[] commands) : base(wrapper, commands)
        {
            MenuDescription = menuDescription;
        }

        protected override void PrintCommands()
        {
            Console.WriteLine($"<{MenuDescription}>");
            base.PrintCommands();
        }
    }
}

using examen.Menues;


namespace examen.Menus
{
    internal class FirstMenu<TValue> : Menu<TValue>
    {
        public FirstMenu(params ICommand<TValue>[] commandsFM) : base(commandsFM) {}
    }
}

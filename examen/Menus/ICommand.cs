
namespace examen.Menus
{
    public interface ICommand<TValue>
    {
        string Description { get; }
        void Execute();
    }
}

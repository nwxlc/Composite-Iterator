namespace Composite;

public class Menu : MenuComponent
{
    private List<MenuComponent> _menuComponents = new List<MenuComponent>();
    
    public Menu(string name)
        :base(name)
    {}
    
    public override void Add(MenuComponent component)
    {
        ArgumentNullException.ThrowIfNull(component);
        _menuComponents.Add(component);
    }
 
    public override void Remove(MenuComponent component)
    {
        ArgumentNullException.ThrowIfNull(component);
        _menuComponents.Remove(component);
    }
 
    public override void Print()
    {
        Console.WriteLine(name);
        //nwolc
        foreach (MenuComponent component in _menuComponents)
        {
            component.Print();
        }
    }
}
namespace DesignPatterns.Decorator;

// concrete implementation
public class Pizza : IPizza
{
    public string GetPizzaType()
    {
        return "This is a normal Pizza";
    }
}

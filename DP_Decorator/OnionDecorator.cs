namespace DesignPatterns.Decorator;

// concrete decorator3
class OnionDecorator : PizzaDecorator
{
    public OnionDecorator(IPizza pizza) : base(pizza)
    {
    }

    public override string GetPizzaType()
    {
        string type = base.GetPizzaType();
        type += "\r\n with extra onions!";
        return type;
    }
}
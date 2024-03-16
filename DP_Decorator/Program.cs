using DesignPatterns.Decorator;

IPizza pizza = new Pizza();
IPizza cheeseDecorator = new CheeseDecorator(pizza);
IPizza tomatoDecorator = new TomatoDecorator(cheeseDecorator);
IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
Console.WriteLine(onionDecorator.GetPizzaType());

namespace InterfaceWithSameMethod;

public class Program : IInterface1, IInterface2
{
    void IInterface1.Method()
    {
    Console.WriteLine("Method from Interface1 is called here.");
    }
     
    void IInterface2.Method()
    {
        Console.WriteLine("Method from Interface2 is called here.");
    }

    public static void Main(string[] args)
    {
        Program program = new ();
        IInterface1 interface1 = program;
        IInterface2 interface2 = program;

        interface1.Method(); // Calls IInterface1.Method()
        interface2.Method(); // Calls IInterface2.Method()   
    }
}
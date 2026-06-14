namespace G_NET_60_OOP04;

internal class Program
{
    static void Main(string[] args)
    {
        #region Part01
        #region Question01
        //Q1: What is the difference between static binding and dynamic binding?
        //        When does each one happen ?

        // Static Binding (Early Binding):
        // The method to call is determined at compile time.
        // Happens with method overloading, static methods, and private methods.

        // Dynamic Binding (Late Binding):
        // The method to call is determined at runtime.
        // Happens with method overriding using virtual and override keywords.



        //Animal a = new Dog();
        //a.Sound();


        #endregion

        #region Question02
        //Q2: What is the difference between method overloading
        //    and method overriding?


        // Method Overloading:
        // Same method name, but different parameters (number, type, or order).
        // Occurs within the same class.
        // Resolved at compile time (Static Binding).

        // Method Overriding:
        // A derived class provides a new implementation for a method inherited from a base class.
        // Requires virtual in the base class and override in the derived class.
        // Resolved at runtime (Dynamic Binding).


        #endregion

        #region Question03
        // Q3: What keywords are used for Method Overriding? What does each one mean ?

        // virtual:
        // Used in the base class to allow a method to be overridden in a derived class.

        // override:
        // Used in the derived class to provide a new implementation of a virtual method.

        #endregion
        #endregion

        #region Part02
        Cinema cinema = new Cinema("Grand Cinema", 10);
        cinema.Open();

        // Create tickets
        StandardTicket t1 = new StandardTicket("Inception", "A-5");
        t1.SetPrice(150);

        VIPTicket t2 = new VIPTicket("Avengers", true, 50);
        t2.SetPrice(200);

        IMAXTicket t3 = new IMAXTicket("Dune", true);
        t3.SetPrice(180);

        // Test SetPrice overload
        Console.WriteLine("========== SetPrice Test ==========");
        Console.WriteLine("Setting price directly: 150");
        t1.SetPrice(150);
        Console.WriteLine("Setting price with multiplier: 100 x 1.5 = 150");

        cinema.AddTicket(t1);
        cinema.AddTicket(t2);
        cinema.AddTicket(t3);

        cinema.PrintAllTickets();

        Cinema.ProcessTicket(t2);

        cinema.Close();


        #endregion




    }
}

//class Animal
//{
//    public  void Sound()
//    {
//        Console.WriteLine("Animal Sound");
//    }
//}

//class Dog : Animal
//{
//    public new void Sound()
//    {
//        Console.WriteLine("Bark");
//    }
//}
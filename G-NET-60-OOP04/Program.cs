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



        Animal a = new Dog();
        a.Sound();


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



        #endregion



    }
}

class Animal
{
    public  void Sound()
    {
        Console.WriteLine("Animal Sound");
    }
}

class Dog : Animal
{
    public new void Sound()
    {
        Console.WriteLine("Bark");
    }
}
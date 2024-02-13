//Console.WriteLine("Hello, OS");

namespace SealedAndPrivate
{
    public class Class1
    {
        public virtual void Method1()
        {
            Console.WriteLine("Class1 Method1");
        }
    }
    public class Class2 : Class1
    {
        //Sealed Method
        public sealed override void Method1()
        {
            Console.WriteLine("Class2 Sealed Method1");
        }

        //Private Method
        private void Method2()
        {
            Console.WriteLine("Class2 Private Method2");
        }
    }

    public class Class3 : Class2
    {
        //We cannot override Method1 because it is sealed in Class2
        //But this method is inherited and hence we can access this method
        //using Class3 instance
        //public override void Method1()
        //{
        //    Console.WriteLine("InkJet Printer Printing...");
        //}
        //Class2 Private Method Method2 is not inherited to child class and hence
        //you can define the same method here
        public void Method2()
        {
            Console.WriteLine("Class3 public Method2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj1 = new Class2();
            obj1.Method1();
            Class3 obj3 = new Class3();
            obj3.Method1();
            obj3.Method2();
        }
    }
}
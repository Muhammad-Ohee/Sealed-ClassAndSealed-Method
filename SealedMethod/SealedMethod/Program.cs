//Console.WriteLine("Hello, OS");

namespace SealedMethod
{
    class Parent
    {
        public virtual void Show() { }
    }
    class Child : Parent
    {
        public sealed override void Show() { }
    }
    class GrandChild : Child
    {
        //'GrandChild.Show()': cannot override inherited member 'Child.Show()' because it is sealed
        //public override void Show() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
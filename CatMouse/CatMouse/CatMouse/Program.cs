using System;

namespace CatMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(new Mouse());
            cat.Shout();
        }
    }
}

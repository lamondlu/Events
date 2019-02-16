using System;
using System.Collections.Generic;
using System.Text;

namespace CatMouse
{
    public class Cat
    {
        private Mouse _mouse;

        public Cat(Mouse mouse)
        {
            _mouse = mouse;
        }

        public void Shout()
        {
            Console.WriteLine("猫叫了。");

            _mouse.Run();
        }
    }
}

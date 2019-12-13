using System;
using Game;

namespace Shia
{
    public class Program
    {
        public static void Main()
        {
            Woods.Begin();
            Woods.Again(Woods.Play(0));
        }
    }
}

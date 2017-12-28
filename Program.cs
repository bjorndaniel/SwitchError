using System;
using Ooui;

namespace SwitchError
{
    class Program
    {
        static void Main(string[] args)
        {
            Xamarin.Forms.Forms.Init();
            new SwitchPage().Publish();
            UI.Present("/switch");
            Console.ReadLine();
        }
    }
}

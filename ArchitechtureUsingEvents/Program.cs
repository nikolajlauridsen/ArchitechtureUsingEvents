using System;

namespace ArchitechtureUsingEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        public void Run()
        {
            Message message = new Message();
            MLength mLength = new MLength();
            Screen screen = new Screen(message, mLength);
            screen.ShowScreen();
        }
    }
}

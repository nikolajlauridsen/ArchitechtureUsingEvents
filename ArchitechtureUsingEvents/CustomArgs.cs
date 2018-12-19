using System;

namespace ArchitechtureUsingEvents
{
    public class CustomArgs : EventArgs
    {
        //implement as described in the class diagram
        public string MessageBefore;
        public string MessageAfter;
        public CustomArgs(string before, string after)
        {
            MessageBefore = before;
            MessageAfter = after;
        }
    }
}

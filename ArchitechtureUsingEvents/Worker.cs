using System;

namespace ArchitechtureUsingEvents
{
    public class Worker
    {
        private readonly IScreen screen;
        private IMessage message;

        public Worker(IScreen screen, IMessage message)
        {
            this.screen = screen;
            this.message = message;
        }

        public void ReverseTextValue()
        {
            char[] arr = screen.TextValue.ToCharArray();
            Array.Reverse(arr);
            message.MyMessage = new string(arr);
        }

        public void SetTextValue()
        {
            screen.MessageLength.MessageLength = message.MyMessage.Length.ToString();
            message.MyMessage = screen.Answer;
        }
    }
}

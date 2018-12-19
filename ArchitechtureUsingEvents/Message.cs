using System;

namespace ArchitechtureUsingEvents
{
    public class Message : IMessage
    {
        public event EventHandler<CustomArgs> MessageSetEvent;
        private string myMessage;

        public string MyMessage {
            get { return this.myMessage; }
            set {
                //should change myMessage and raise the MessageSetEvent
                //To do that we need an CustomArgs instance holding the
                //old (before) and new (after) value of myMessage
                CustomArgs args = new CustomArgs(myMessage, value);
                myMessage = value;

                MessageSetEvent(this, args);
            }
        }

        public Message()
        {
            this.myMessage = "No message";
        }
    }
}

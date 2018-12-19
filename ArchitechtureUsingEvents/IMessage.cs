using System;

namespace ArchitechtureUsingEvents
{
    public interface IMessage
    {
        event EventHandler<CustomArgs> MessageSetEvent;
        string MyMessage { get; set; }
    }
}

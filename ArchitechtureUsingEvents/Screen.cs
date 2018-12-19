using System;

namespace ArchitechtureUsingEvents
{
    public class Screen : IScreen
    {
        public string Answer { get; set; }
        public string Warning { get; set; }
        public string TextValue { get; set; }

        private readonly string exitString = "q";
        public Worker MyWorker { get; set; }
        public MLength MessageLength { get; set; }

        public Screen(IMessage message, MLength mLength)
        {
            MessageLength = mLength;
            TextValue = message.MyMessage + $" length: {MessageLength.MessageLength}";
            Warning = "Nothing to warn about";

            //Screen needs to add its MessageSetEventHandler method
            //to the event in message
            message.MessageSetEvent += MessageSetEventHandler;

            //Also Screen needs to create its worker instance
            MyWorker = new Worker(this, message);
        }

        void MessageSetEventHandler(object sender, CustomArgs customArgs)
        {
            //sender is not used as all information needed is in customArgs

            TextValue = customArgs.MessageAfter + $" length: {MessageLength.MessageLength}";
            Warning = $"Text changed from: \"{customArgs.MessageBefore}\"";
        }

        public void ShowScreen()
        {
            bool stop;
            do {
                Console.Clear();
                Console.WriteLine("*************************************");
                Console.WriteLine($"Warning : {Warning}");
                Console.WriteLine($"Text : {TextValue}\n");
                Console.WriteLine("*************************************\n");
                Console.WriteLine($"Enter \"{exitString}\" to exit program");
                Console.WriteLine($"Enter \"r\" to reverse \"Text\"");
                Console.WriteLine($"Any other text changes \"Text\"\n");
                Console.Write("Enter choice: ");
                Answer = Console.ReadLine();
                if (Answer.ToUpper().Equals("R")) {
                    //The Message.MyMessage should be changed to the reverse
                    //If it was "Hello mom" it should be "mom olleH"
                    MyWorker.ReverseTextValue();
                } else {
                    //The Message.MyMessage should change to the text in Answer
                    MyWorker.SetTextValue();
                }
                stop = Answer.ToUpper().Equals(exitString.ToUpper());
            } while (stop == false);
        }
    }
}

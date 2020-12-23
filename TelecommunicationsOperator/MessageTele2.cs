using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    class MessageTele2 : MessageBase
    {
        public MessageTele2(string message, string voiceMessage) : base(message, voiceMessage)
        {
        }

        public override void Send()
        {
            Console.WriteLine($"Оператор Tele2: {Message}, {VoiceMessage}");
        }
    }
}

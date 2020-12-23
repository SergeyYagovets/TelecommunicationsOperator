using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    public class MessageMegafon : MessageBase
    {
        public MessageMegafon(string message, string voiceMessage) : base(message, voiceMessage) { }
        public override void Send()
        {
            Console.WriteLine($"Оператор Megafon: {Message}, {VoiceMessage}");
        }
    }
}

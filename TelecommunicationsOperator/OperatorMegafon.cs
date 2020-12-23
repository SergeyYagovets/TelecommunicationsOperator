using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    public class OperatorMegafon : OperatorBase
    {
        public OperatorMegafon(int phoneNumber, int codeNumber) : base(phoneNumber, codeNumber) { }

        public override IMessage CreateMessage(string message, string voiceMessage)
        {
            var messageMegafon = new MessageMegafon(message, voiceMessage);
            return messageMegafon;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    class OperatorTele2 : OperatorBase
    {
        public OperatorTele2(int phoneNumber, int codeNumber) : base(phoneNumber, codeNumber)
        {
        }
        public override IMessage CreateMessage(string message, string voiceMessage)
        {
            var messageTele2 = new MessageTele2(message, voiceMessage);
            return messageTele2;
        }
    }
}

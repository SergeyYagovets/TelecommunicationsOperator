using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    public class OperatorMTS : OperatorBase
    {
        /// <summary>
        /// Реализация сообщений 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="voiceMassage"></param>
        public OperatorMTS(int phoneNumber, int codeNumber) : base(phoneNumber, codeNumber)
        {
        }
        public override IMessage CreateMessage(string message, string voiceMessage)
        {
            var messageMts = new MessageMTS(message, voiceMessage);
            return messageMts;
        }
    }
}

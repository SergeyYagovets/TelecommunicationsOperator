using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    /// <summary>
    /// Сообщения для МТС
    /// </summary>
    public class MessageMTS : MessageBase
    {
        /// <summary>
        /// Новый экземпляр сообщений МТС
        /// </summary>
        /// <param name="message"></param>
        /// <param name="voiceMassage"></param>
        public MessageMTS(string message, string voiceMessage) : base(message, voiceMessage)
        {
        }
        /// <summary>
        /// Отправка сообщения
        /// </summary>
        public override void Send()
        {
            Console.WriteLine($"Оператор МТС: {Message}, {VoiceMessage}");
        }
    }
}

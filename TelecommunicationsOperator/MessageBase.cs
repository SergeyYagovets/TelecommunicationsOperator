using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    /// <summary>
    /// Реализация интерфейса 
    /// </summary>
    public abstract class MessageBase : IMessage
    {
        public string Message { get; }

        public string VoiceMessage { get; }

        public MessageBase(string message, string voiceMessage)
        {
            // Проверка входящих параметров
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentNullException(nameof(message), "Нельзя отправить пустое сообщение!");
            }
            if (string.IsNullOrWhiteSpace(voiceMessage))
            {
                throw new ArgumentNullException(nameof(voiceMessage), "Нельзя отправить пустое голосовое сообщение!");
            }
            Message = message;
            VoiceMessage = voiceMessage;
        }
        /// <summary>
        /// Отправка сообщений
        /// </summary>
        public abstract void Send();
    }
}

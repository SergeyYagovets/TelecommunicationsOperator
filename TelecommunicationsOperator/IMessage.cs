using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    public interface IMessage
    {
        /// <summary>
        /// Базовый интерфейс связи для всех сим карт 
        /// </summary>
        string Message { get; }
        string VoiceMessage { get; }
        void Send();

    }
}

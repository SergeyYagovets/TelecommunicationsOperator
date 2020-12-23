using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    public abstract class OperatorBase : IOperator
    {
        /// <summary>
        /// Номер оператора
        /// </summary>
        public int PhoneNumber { get; }

        /// <summary>
        /// код оператора
        /// </summary>
        public int CodeNumber { get; }

        public OperatorBase(int phoneNumber, int codeNumber)
        {
            if (5 > phoneNumber & 3 <= codeNumber)
            {
                throw new Exception("Введен не верный формат!");
            }
            PhoneNumber = phoneNumber;
            CodeNumber = codeNumber;
        }
        /// <summary>
        /// Сообщение для отправки
        /// Фабричный метод
        /// </summary>
        /// <param name="phoneNumber">Номер оператора</param>
        /// <param name="codeNumber">Код оператора</param>
        /// <returns></returns>
        public abstract IMessage CreateMessage(string message, string voiceMessage);
    }
}

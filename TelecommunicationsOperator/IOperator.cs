using System;
using System.Collections.Generic;
using System.Text;

namespace TelecommunicationsOperator
{
    public interface IOperator
    {
        /// <summary>
        /// Базовый интерфейс для реализации разных сим карт
        /// </summary>
        int PhoneNumber { get; }
        int CodeNumber { get; }
    }
}

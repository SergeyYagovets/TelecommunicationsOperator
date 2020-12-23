using System;

namespace TelecommunicationsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            var messageMts = new OperatorMTS(123456, 321); // !!!
            var mts = messageMts.CreateMessage("Hi!", "Test");
            mts.Send();

            var messageMegafon = new OperatorMegafon(258741, 926);
            var megafon = messageMegafon.CreateMessage("Message text", "Voice message");
            megafon.Send();

            var messageTele2 = new OperatorTele2(321546, 926);
            var tele2 = messageTele2.CreateMessage("Message text", "Voice message");
            tele2.Send();

            Console.ReadLine();
        }
    }
}

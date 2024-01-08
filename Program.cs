using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            Smartphone nokiaPhone = new Nokia("123456789", "Nokia 8", "IMEI123", 64);
            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            Smartphone iPhone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);
            iPhone.Ligar();
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Instagram");
        }
    }
}

using System;
using AULAPOO_ENCAPSULAMENTO.Classes;

namespace AULAPOO_ENCAPSULAMENTO
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();
            m.NomeTitular = "Ruan";
            m.Bandeira = "MasterCard";
            m.Numero = "CaldoDeCana";
            m.CVV = "234";

            Console.WriteLine($"O titular: {m.NomeTitular}");
            Console.WriteLine($"Possuí o token: {m.Token}");
            Console.WriteLine($"Possuí a bandeira: {m.Bandeira}");
            Console.WriteLine($"Número: {m.Numero}");
            Console.WriteLine($"CVV: {m.CVV}");
            Console.WriteLine($"Limite: {m.Limite}");
        }
    }
}

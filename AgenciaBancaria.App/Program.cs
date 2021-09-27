using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua teste", "12345678", "Perdeneiras", "SP");
                Cliente cliente = new Cliente("Carla", "123456", "456789", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);
                Console.WriteLine("Conta criada: "+ conta.Situacao +": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                string senha = "abc123456789";
                conta.Abrir(senha);

                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: " + conta.Saldo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

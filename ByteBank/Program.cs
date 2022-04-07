using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


                //--------------------------------------------------------------------
            //LeitorDeArquivos leitor = null;
            //try
            //{
            //    leitor = new LeitorDeArquivos("contas.txt");

            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();

            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }

        public static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(456, 4578420);
                ContaCorrente conta2 = new ContaCorrente(485, 4564783);

                conta1.Transferir(10000, conta2);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(456, 4578420);
            //    ContaCorrente conta2 = new ContaCorrente(485, 456478);

            //    conta2.Transferir(5000, conta);

            //    conta.Depositar(50);
            //    Console.WriteLine(conta.Saldo);
            //    conta.Sacar(-500);
            //}
            //catch (ArgumentException ex)
            //{
            //    if(ex.ParamName == "numero") { }

            //    Console.WriteLine("Argumento com problema: " + ex.ParamName);
            //    Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
            //    Console.WriteLine(ex.Message);
            //}
            //catch(SaldoInsuficienteException ex)
            //{
            //    Console.WriteLine(ex.Saldo);
            //    Console.WriteLine(ex.ValorSaque);

            //    Console.WriteLine(ex.StackTrace);

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Metodo();
        }

        // Teste com a cadeia de chamada:
        // Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }

    }
}

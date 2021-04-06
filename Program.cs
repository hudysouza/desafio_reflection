using DesafioReflection.Interface;
using DesafioReflection.Service;
using System;
using System.Linq;

namespace DesafioReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual arquivo devera ser processado?");
            Console.WriteLine();
            Console.WriteLine("1 - Detran");
            Console.WriteLine("2 - Imagem");
            Console.WriteLine("3 - Renainf");
            Console.WriteLine("4 - Sair");

            Console.WriteLine();
            Console.WriteLine("Digite qual arquivo será processado");

            bool arquivoValido = false;
            var arquivo = "0";

            while (!arquivoValido)
            {
                string[] opcoes = new string[] { "1", "2", "3", "4" };
                arquivo = Console.ReadLine();

                arquivoValido = opcoes.Contains(arquivo);

                if (!arquivoValido)
                {
                    Console.WriteLine("Opção {0} invalida", arquivo);
                }
            }

            if (arquivo == "4")
            {
                Console.WriteLine("Saindo");
                return;
            }

            ProcessarArquivo(arquivo);

            Console.Read();
        }

        //O Desafio consiste em refazer esse metodo sem utilizar IFs ou Switch Case
        public static void ProcessarArquivo(string tipoArquivo)
        {
            IProcessaArquivo processaArquivo;
            switch (tipoArquivo)
            {
                case "1":
                    processaArquivo = new ProcessaDetran();
                    break;
                case "2":
                    processaArquivo = new ProcessaImagem();
                    break;
                case "3":
                    processaArquivo = new ProcessaRenainf();
                    break;
                default:
                    throw new ArgumentException("Tipo de arquivo Invalido");

            }

            processaArquivo.Processa();
        }
    }
}

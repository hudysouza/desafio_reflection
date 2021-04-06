using DesafioReflection.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioReflection.Service
{
    public class ProcessaImagem : IProcessaArquivo
    {
        public void Processa()
        {
            Console.WriteLine("Processou arquivo de Imagem");
        }
    }
}

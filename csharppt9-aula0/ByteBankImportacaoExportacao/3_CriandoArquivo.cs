using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// IO = Input e Output

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "C:\\Users\\manij\\OneDrive\\Documentos\\programação\\C#\\Alura\\csharp-parte-9-Entrada e saida (I-O) com streams\\contasExportadas.csv";

            using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,78945,47812.50,Beatriz Demendi";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        static void CriarArquivoComWrite()
        {
            var caminhoNovoArquivo = "C:\\Users\\manij\\OneDrive\\Documentos\\programação\\C#\\Alura\\csharp-parte-9-Entrada e saida (I-O) com streams\\contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("666, 6454654,4561.0,Matheus Nicolas");
            };
        }


        static void TestaEscrita()
        {
            var caminhoNovoArquivo = "C:\\Users\\manij\\OneDrive\\Documentos\\programação\\C#\\Alura\\csharp-parte-9-Entrada e saida (I-O) com streams\\csharppt9-aula0\\ByteBankImportacaoExportacao\\bin\\Debug\\testa.txt";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 100000000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); // Despeja o buffer para o Stream

                    Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar mais uma!");
                    Console.ReadLine();
                }
            }
        }

    }
}
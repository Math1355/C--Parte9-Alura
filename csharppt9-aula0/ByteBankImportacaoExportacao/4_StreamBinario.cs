using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {

        static void EscritaBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.CreateNew))
            using (var escritor = new BinaryWriter(fs))
            {
                escritor.Write(456); // Número da agencia
                escritor.Write(546544); // Número da conta
                escritor.Write(4000.50); // Saldo da conta
                escritor.Write("Matheus Nicolas");
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var numero = leitor.ReadInt32();
                var saldo = leitor.ReadDouble();
                var nome = leitor.ReadString();

                Console.WriteLine($"{agencia}/{numero} {nome} {saldo}");
            }
        }

    }
}

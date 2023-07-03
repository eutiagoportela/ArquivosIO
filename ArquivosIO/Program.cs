using ArquivosIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        LidandoComFileStreamDireto l = new LidandoComFileStreamDireto();

        l.LendoArquivoExibindoClasse("contas.txt");
        //l.CriarArquivoCSV();
        //l.LerArquivo("contasExportadas.csv");
        Console.ReadLine();
    }
}

/*
 Nesta aula, exploramos alguns recursos da classe StreamReader:

ReadLine para ler uma linha
ReadToEnd para ler o arquivo por completo, carregando-o de uma única vex
Read para ler o primeiro byte do arquivo
EndOfStream para ler e exibir um arquivo até que o fluxo chegue ao fim
 * */
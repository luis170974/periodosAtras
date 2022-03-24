using System;

namespace periodosAtrasConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dataAtual = DateTime.Now;


            Console.WriteLine("Digite uma data para saber quanto tempo passou : ");
            DateTime dataSaberTempo = Convert.ToDateTime(Console.ReadLine());

            TimeSpan quantosDiasPassaram = dataAtual - dataSaberTempo;

            int diasPassados = Math.Abs(Convert.ToInt32(quantosDiasPassaram.TotalDays));
            int mesesPassados = Math.Abs(Convert.ToInt32(dataAtual.Month - dataSaberTempo.Month));
            int anosPassados = Math.Abs(Convert.ToInt32(dataAtual.Year - dataSaberTempo.Year));
            int horasPassadas = Math.Abs(Convert.ToInt32((quantosDiasPassaram.TotalHours)));
            int minutosPassados = Math.Abs(Convert.ToInt32((horasPassadas / 60)));
            int segundosPassados = Math.Abs(Convert.ToInt32(minutosPassados / 60));

            Console.WriteLine("Se passaram : {0} ano(s) {1} mes(es) {2} dia(s) {3} horas {4} minutos {5} segundos", anosPassados , mesesPassados , diasPassados , horasPassadas , minutosPassados , segundosPassados );
            Console.ReadLine();


        }
    }
}

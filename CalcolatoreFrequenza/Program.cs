using System;
using LibreriaFrequanzaElementi;
namespace CalcolatoreFrequenza
{
    class Program
    {
        const int dimensione = 10;
        static void Main(string[] args)
        {
            int[] array_numeri = new int[10];
            int maggiore, volte_max = 1, attuale, volte_attuale;
            Console.WriteLine("10 elementi: ");
            Gestione.LeggiArray(array_numeri);
            Gestione.BubbleSort(array_numeri);
            maggiore = array_numeri[0];
            for (int i = 0; i < array_numeri.Length; i++)
            {
                attuale = array_numeri[i];
                volte_attuale = 1;
                for (int j = i + 1; j < array_numeri.Length; j++)
                {
                    if (array_numeri[i] == array_numeri[j])
                        volte_attuale++;
                }
                if (volte_attuale > volte_max)
                {
                    maggiore = attuale;
                    volte_max = volte_attuale;
                }
            }
            Console.WriteLine($"Il numero che compare piu' volte e' {maggiore} e si ripete {volte_max} volte");




            /*int j = 0;
            for (int i = 0; i < array_numeri.Length - 1; i++)
            {
                if (array_numeri[i] == array_numeri[i + 1])
                {
                    j++;
                }
            }
            int[] array_frequenze = new int[j];
            for (int i = 0, k = 0; i < array_numeri.Length - 1; i++)
            {
                if (array_numeri[i] == array_numeri[i + 1])
                {
                    array_frequenze[k] = array_numeri[i];
                    k++;
                }
            }
            Console.WriteLine("Le frequenze sono: ");
            Gestione.StampaArray(array_frequenze);*/
        }
    }
}

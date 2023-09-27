using System;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Random rand = new Random();
            int n = 20;
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 10);
                Console.Write("{0,3} ", arr[i]);
            }
            Console.WriteLine();
            int k;

            for (int i = 0; i < arr.Length; i++)
            {
                k = 0;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                        break;
                }
                for (int l = i; l < arr.Length; l++)
                {
                    if (arr[i] == arr[l])
                        k++;
                }
                Console.WriteLine("Chislo {0} povtoryaetsa {1} raz", arr[i], k);
            }
            {
                Console.WriteLine();
                {
                    Console.WriteLine("Esli hotite povtorit vvod, vvedite 1, inache lubuyu dr cifru");
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1) Main();
                    return;
                }
                Console.ReadLine();
            }
        }
    }
}

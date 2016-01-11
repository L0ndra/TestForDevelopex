using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestForDevelopex
{
    class Program
    {
        static int N = 10000;
        static void GenerateList()
        {
            Random rand = new Random();
            int N = 10000;
            List<int> Numbers = new List<int>();
            for(int i=0;i< N;i++)
            {
                Numbers.Add(i);
            }
            using (StreamWriter sw = new StreamWriter("out.txt"))
            {
                while (N > 0)
                {
                    int i = rand.Next() % N;
                    int k = Numbers[i];
                    sw.Write("{0}, ", k);
                    Numbers.RemoveAt(i);
                    N--;
                }
            }
        }
        static void Main(string[] args)
        {
            GenerateList();
        }
    }
}

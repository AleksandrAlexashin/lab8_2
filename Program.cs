using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string put = "lab8txt";
            if (!Directory.Exists(put))
            {
                Directory.CreateDirectory(put);
            }

                   
            
            
            string put1 = "lab8txt/lab8.txt";
            if (!File.Exists(put1))
            {
                File.Create(put1);
            }

            
           
            using (StreamWriter sw = new StreamWriter(put1))

            {
                int[] mass = new int[10];
                Random rnd = new Random();
                for (int i = 0; i < 10; i++)
                {
                    mass[i] = rnd.Next(0,20);
                    sw.WriteLine(mass[i]);
                    Console.Write(mass[i]+" ");

                }
                
            }
            Console.WriteLine();
            int[] m = new int[10];
            int s = 0;
            
            using (StreamReader sr = new StreamReader(put1))
            {
                
                     while (sr.Peek() >= 0)
                     { 
                 
                      
                        for (int i = 0; i < 10; i++)
                        { 
                        m[i] = Convert.ToInt32(sr.ReadLine());
                        s += m[i];
                        }
                      
                     }
               
            }
            Console.WriteLine("Среднее арифметическое равно {0:f1}",(double)s/10);
            Console.ReadKey();

        }

               
    }
        
}

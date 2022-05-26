using System;

namespace verilmisadlarsiyahisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = NameList(new string [] { "Aysel", "Ehmed", "Lale", "Murad", "Arzu", "Eli" });
            Console.WriteLine(count);
        }

        //Verilm is adlar siyahisinda (string array) nece adin
        //uzunlugunun 5 den boyuk oldugunu tapan program
        static void NameList(string[] names)
        {
            
            int count = 0;
            for(int i=0; i<names.Length, i++)
            {
                if (names[i].Lengtgh > 5)
                    count++;
            }
            return count;

        }
        

    }
}

using System;

namespace dersde
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers= new int[] { 45, 2, 2, 21, 2, 3 };
          
            Console.WriteLine(FindNumberCount(numbers, 2));

            int avg = CalcAvgPoint(new int[] { 45, 80, 43, 10, 5, 3, 100 });
            Console.WriteLine("Qiymetlerin sayini daxil edin");
            string pointsCountStr = Console.ReadLine();
            int pointCount = Convert.ToInt32(pointsCountStr);
            int[] points = new int[pointCount];
            for(var i=0; i<points.Length; i++)
            {
                Console.WriteLine("Qiymeti daxil edin");
                string pointStr = Console.ReadLine();
                points[i] = Convert.ToInt32(pointStr);

                string[] names = { "Hikmet ", "Abbas", "Orxan", "ayten" };
                string name = "Abbas";
                Console.WriteLine(HasName(names, name);

            }
        }
        //Verilmis ededler siyahisinda verilmis n ededinin sayini tapan metod
        static int FindNumberCount(int[] numbers, int n)
        {
            int count = 0;
            for(int i=0; i<numbers.Length; i++)
            {
                if(numbers[i]==0)
                {
                    count++;
                }
            }
            return count;

        //Verilmis qiymetlerin ededi ortalamasini tapan metod
        static int CalcAvgPoint(int[] points)
            {
                int sum = 0;
                int avg = 0;
                    for(int i=0; i<points.Length; i++)
                {
                    sum += points;
                }
                if (points.Length > 0)
                    avg = sum / numbers.Length;
                return avg
                    
            }
        }

        //Verilmis adlar siyahisinda axtarilan adin olub olmadigini tapan metod
        static bool HasName(string [] names, string wantedname)
        {
            for(var i=0; i<names.Length; i++)
            {
                if (names[i] == wantedname)
                    return true;
            }
            return false;
        }
    }
}

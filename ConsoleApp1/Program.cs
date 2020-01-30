using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Fact(double n)
        {
            double r = 1;
            for (int i = 2; i <= n; i++)
            {
                r *= i;
            }
            return r;
        }
        static double soch(double n, double m)
        {
            double r = Fact(n) / (Fact(n - m) * Fact(m));
            return r;
        }
        static double razm(double n, double m)
        {
            double r = Fact(n) / Fact(n - m);
            return r;
        }

        static void Main(string[] args)
        {
            double [] arr=new double [40];
            
            int nf = 0;
            int nmmf = 0;
            int mf = 0;
            int dr = 0;
            int result = 0;
            double n = 52;
            double m = 3;
            double first_one = 0;
            double second_one = 0;
            int third_one = 0;
            string resultat = "";
            int count = 0;
            int fixcount =0;


            //     nf = Fact(n);
            //     Console.Write(nf);
            /*
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            string Meaning=Console.ReadLine();
            if(Meaning="Yes"||Meaning="Y"||Meaning="Да"){
            
            }
            string Meaning2=Console.ReadLine();
            if(Meaning2="Yes"||Meaning2="Y"||Meaning2="Да"){
            
            }
             */
            first_one=soch(n,m);
            Console.WriteLine(first_one);
            Console.WriteLine(soch(52, 2)*4);
            Console.Write(soch(52,1)* soch(52, 1)*2+ soch(52, 1)*6+soch(12,1)/*+soch(52,6)+soch(12,1)*/);
            /*
            Console.WriteLine(Fact(n) / (Fact(n - m) * Fact(m)));
                for (int i = 1; i < 53; i++) {
                for (int i1= 1; i1 < 53; i1++)
                    {
                    for (int i2 = 1;i2 < 53;i2++ )
                        {
                            Console.WriteLine(i + " " + i1 + " " + i2+"           " + count);
                            count++;  
                            if ((i==3)&&(i1==7)&&(i2==12)) { fixcount = count; }
                        }
                    
                }


                }
            Console.WriteLine(fixcount);
            Console.WriteLine((7 * 12) * 3);*/

            /* Здесь идет то чего сейчас не надо
            Console.WriteLine(Fact(6) / (Fact(4) * Fact(2)));
            Console.WriteLine(Fact(9) / (Fact(7) * Fact(2)));
            Console.WriteLine(Fact(5) / (Fact(3) * Fact(2)));
            Console.WriteLine(Fact(52));
            Console.WriteLine(Fact(5));
            Console.WriteLine(Fact(52) / Fact(52 - 3));
            Console.WriteLine(2 * 6 * 4);
            Console.WriteLine(2 * 6 * 4);
            Console.WriteLine(Fact(10) / Fact(4));
            Console.WriteLine(Fact(3));
            Console.WriteLine(Fact(3) / Fact(1));
            Console.WriteLine(Fact(3) / Fact(1));
            //Следующая задача бп как решается
            Console.WriteLine(Fact(3) / Fact(1));
            Console.WriteLine(Fact(3) / Fact(1));*/
            Console.ReadLine();

                                

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinZadatakPeti
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 40; i++)
            {   
                for(int j=1;i<40;i++)
                { 
                    for(int a=1;a<40;a++)
                    {
                        for(int b=1;b<40;b++)
                        {
                            for (int c=1;c<40;c++)
                            {
                                for (int d = 1; i < 40; d++)
                                {
                                    for(int e=1;i<40;d++)
                                    {
                                        Console.WriteLine(i+" "+j+" "+a+" "+b+" "+c+" "+d+" "+e);

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

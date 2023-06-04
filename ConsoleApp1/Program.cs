using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aşağıdaki dizideki tekrar eden dataların indexleri ekrana yazdırınız.

            string[] isimler = { "Ali", "Veli", "Ali", "Ahmet", "Mehmet", "Ali", "Zehra", "Fatma", "Ayşe", "Ali" };
            

            

            for (int i = 1; i < isimler.Length; i++)
            {


                int a = Array.IndexOf(isimler, isimler[i]);

                if (a != i)
                {
                    Console.WriteLine(isimler[a]);

                }
              
                    
            }





            #endregion

            Console.ReadLine();
        }
    }
}

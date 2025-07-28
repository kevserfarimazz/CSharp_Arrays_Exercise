using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Yeşil";

            //Console.WriteLine(colors[2]);




            //string[] cities= new string[5];

            //cities[0] = "Ankara";
            //cities[1] = "Mekke";
            //cities[2] = "Milano";
            //cities[3] = "Lyon";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[2]);




            //int[] numbers=new int[10];
            //numbers[0] = 1389;
            //numbers[1] = 293012;
            //numbers[7] = 31289;
            //numbers[4] = 48329;

            //Console.WriteLine(numbers[7]);



            //string[] cities = { "Prag", "Ankara", "Sivas", "Samsun" };

            //Console.WriteLine(cities[3]);
            #endregion

            #region Dizideki tüm elemanları listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Mor", "Pembe", "Yeşil" };

            //for(int i=0;i<colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}




            //int[] numbers = { 4, 24, 56, 78, 2, 34, 45, 5766, 567865 };

            //for(int i=0; i<numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}




            //char[] symbols = { 'a', 'b', '*', '/', '-' };
            //for(int i=0; i<symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myArray = { 34, 56, 78, 6547, 6789, 90, 2, 3, 45, 45 };

            //int maxNumber = myArray[0];

            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber= myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region lengt

            //string[] persons = { "Ali", "Mina", "Kevser", "Ömer","Buse","Cem" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 23, 45, 56, 678, 12,34,23,45,56,678,12,34,56};
            //Array.Sort(numbers);
            //for(int i=0; i<numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 23, 45, 56, 678, 12, 34, 23, 45, 56, 678, 12, 34, 56 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Cemre", "Deren", "Yasemin", "Can" };
            //int index = Array.IndexOf(customers, "Deren");
            //Console.WriteLine(index);




            //int[] numbers = { 34, 34, 54, 564, 5, 23, 55, 66, 787, 88, 98, 20 };
            //Console.WriteLine("Dizinin en büyük iki elemanı: " + numbers.Max() +
            //    " Dizinin en küçük elemanı: " + numbers.Min());
            #endregion

            #region kullanıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehrini giriniz: ");
            //    cities[i]= Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");

            //for (int i = 0; i < cities.Length; i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);



            //int[] numbers = { 1, 2, 234, 57, 2334, 562, 354, 62, 3345};
            //int sum = 0;


            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}   
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

                
            




          
            #endregion

            Console.Read();
        }

    }
}

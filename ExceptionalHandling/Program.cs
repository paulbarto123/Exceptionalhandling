using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
            int i = 1;
            string yesDefault = "YES";
            while (i > 0)
            {
                Console.WriteLine("Type Yes To Restart The Programm\n ");
                string YesConfirm = Console.ReadLine();
                if (yesDefault.Equals(YesConfirm, StringComparison.CurrentCultureIgnoreCase))
                {
                    StartProgram();
                }
                else
                {
                    i--;
                }

            }
        }
        static void StartProgram()
        {
            Console.WriteLine("Input Number From 1-4\n" +
                "1. Body Mass Index\n" +
                "2. Reprint Name\n" +
                "3. Print Even's Character\n" +
                "4. Sum Inputted Array ");
            try
            {
                int pilihan = int.Parse(Console.ReadLine());
                switch (pilihan)
                {
                    case 1:
                        BMI();
                        break;
                    case 2:
                        ReprintName();
                        break;
                    case 3:
                        PrintEvenCharacter();
                        break;
                    case 4:
                        SumInputtedArray();
                        break;
                    default:
                        Console.WriteLine("Please Input Number From 1-4");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Please Input Number Only");
            }

        }
        static void BMI()
        {

            try
            {
                Console.Write("Input Your Weight (kg) \n");
                float n = float.Parse(Console.ReadLine());
                Console.WriteLine("Input Your Height (cm)");
                float m = (float.Parse(Console.ReadLine())) / 100;
                if (m == 0)
                {
                    throw new Exception("Not Valid Input");
                }
                float bmi = n / (m * m);
                if (bmi < 18.1)
                {
                    Console.WriteLine("Your BMI's {0} You're Underweight", bmi);
                }
                else if (bmi >= 18.1 && bmi < 23.1)
                {
                    Console.WriteLine("Your BMI's {0} You're Normal", bmi);
                }
                else if (bmi >= 23.1 && bmi <= 28.1)
                {
                    Console.WriteLine("Your BMI's {0} You're Overweight", bmi);
                }
                else if (bmi > 28.1)
                {
                    Console.WriteLine("Your BMI's {0} You're Obese", bmi);

                }
            }
            catch (FormatException) { Console.WriteLine("Don't Input Letter"); }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
        static void ReprintName()
        {
            Console.WriteLine("Please Input Your Name");
            try
            {
                String nama = Console.ReadLine();

                for (int i = 0; i < nama.Length; i++)
                {
                    if (char.IsDigit(nama[i]))
                    {
                        throw new Exception("Don't Input Number ");
                    }

                    Console.WriteLine("Huruf Ke {0} adalah {1}", i + 1, nama[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void PrintEvenCharacter()
        {
            try
            {
                Console.WriteLine("Please Input Your Name");
                String nama = Console.ReadLine();
                for (int i = 0; i < nama.Length; i++)
                {
                    if (char.IsDigit(nama[i]))
                    {
                        throw new Exception("Don't Input Number ");
                    }
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(nama[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void SumInputtedArray()
        {
            int[] number = new int[10000];
            int sum = 0;
            try
            {
                Console.WriteLine("Please Input Array Size");
                int size = int.Parse(Console.ReadLine());
                for (int i = 0; i < size; i++)
                {
                    {
                        number[i] = int.Parse(Console.ReadLine());
                        sum += number[i];
                    }

                }
            }

            catch
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine(sum);
        }
    }
}


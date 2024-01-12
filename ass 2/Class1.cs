using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ass_2
{
    internal class Class1
    {

        public void questionOne()
        {
            Console.WriteLine("Enter number:");
            string inputpure = Console.ReadLine();
            bool isInteger = int.TryParse(inputpure, out int number);
            int Counter = 0;
            if (isInteger)
            {
                Console.WriteLine($"your nuber is {number}");
            }
            else
            {
                Console.WriteLine($"plz enter a valied number");

            }
            List<int> listInput = new List<int>();
            while (inputpure != null)
            {
                Console.WriteLine($"enter your list numbers");
                inputpure = Console.ReadLine();
                isInteger = int.TryParse(inputpure, out int listNumbers);
                if (isInteger)
                {
                    listInput.Add(listNumbers);
                }
                else if (inputpure == "done")
                {
                    foreach (var item in listInput)
                    {
                        if (item == number)
                        {
                            Counter++;


                        }

                    }
                    Console.WriteLine($"this {number} has been repated for {Counter} times");
                    Thread.Sleep(5000);
                    break;
                }

                else
                {
                    Console.WriteLine($"plz enter a valied number");

                }


            }
        }
        public void questionTwo()
        {
            List<string> listone = new List<string>();
            List<string> listTwo = new List<string>();
            List<string> ruslte = new List<string>();

            while (true)
            {
                Console.WriteLine($"enter your list one numbers");
                string  inputpure =Console.ReadLine();
                listone.Add(inputpure);
                if (inputpure == "done")
                {
                    if (inputpure == "stop")
                    {
                        for (int i = 0; i < listone.Count; i++)
                        {
                            for (int j = 0; j < listTwo.Count; j++)
                            {
                                if (listone[i] != listTwo[j])
                                {
                                    ruslte.Add(listone[i]);



                                };
                            }

                        }
                        Console.WriteLine($"the ruselte is {ruslte}");
                        Thread.Sleep(5000);
                        break;
                    }
                    Console.WriteLine($"enter your list two numbers");
                     inputpure = Console.ReadLine();
                    listTwo.Add(inputpure);
                

                }





            }

        }
    }
}

using System;
using System.Collections;
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
            try
            {
                if (isInteger)
                {
                    Console.WriteLine($"your number is {number}");
                }
                else
                {
                    Console.WriteLine($"plz enter a valied number");

                }
                List<int> listInput = new List<int>();
                while (inputpure != null)
                {
                    Console.WriteLine($"enter your list numbers    ( to stop just write 'done')");
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
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        /// <summary>
        /// in this function  i get the input of the first list and thin call anther function to complete the compartion 
        /// </summary>
        public void questionTwo()
        {
            List<string> listone = new List<string>();
            string listOneInput = "";

            try
            {
                while (true)
                {
                    Console.WriteLine($"enter your list one elements    ( when you finish  just write 'done')");
                    listOneInput = Console.ReadLine();
                    listone.Add(listOneInput);
                    if (listOneInput == "done")
                    {
                        listone.Remove("done");
                        ListTwoCom(listone); // caling the function that make my code readable 
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// this function is working to compare the numbers in list one and list two and generate new one to add the uniqe values 
        /// this function follwed by the questionTwo() function to solve the Q2 
        /// </summary>
        /// <param name="ListTwoCom"></param>
        public void ListTwoCom(List<string> listone)
        {
            List<string> listTwo = new List<string>();
            List<string> ruslte = new List<string>();

            string listTwoInput = "";

            while (listTwoInput != "stop")
            {


                Console.WriteLine($"enter your list two elemeent     ( when you finish just write 'stop')");
                listTwoInput = Console.ReadLine();
                listTwo.Add(listTwoInput);
                listTwo.Remove("stop");

            }
            if (listTwoInput == "stop")
            {
                for (int i = listone.Count - 1; i >= 0; i--)
                {
                    for (int j = listTwo.Count - 1; j >= 0; j--)
                    {
                        if (listone[i] == listTwo[j])
                        {
                            listone.RemoveAt(i);
                            listTwo.RemoveAt(j);
                            break; // Break out of the inner loop if a match is found and removed
                        }
                    }
                }


            }
            ruslte.AddRange(listone);
            ruslte.AddRange(listTwo);
            Console.WriteLine($"the list devoid is {string.Join(", ", ruslte)}");


        }


        /// <summary>
        /// 
        /// </summary>
        public void thirdQuestion()
        {

            try
            {
                Console.WriteLine(" enter minimum index ");
                string minimum = Console.ReadLine();
                bool isMinimumInteger = int.TryParse(minimum, out int intMinimum);
                Console.WriteLine(" enter maximum  index ");
                string maximum = Console.ReadLine();
                bool isMaximumInteger = int.TryParse(maximum, out int intMaximum);


                if (isMaximumInteger && isMinimumInteger)
                {
                    SumOfListNumbers(intMinimum, intMaximum); // calling the codes that the sum the numbers in anther fun and bring the answer back 
                }
                else
                {
                    Console.WriteLine(" plz enter an integer for the min and maz index of this list  ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        /// <summary>
        /// in this function i created a way to sum the input numbers betwwen the min and max index 
        /// </summary>
        /// <param name="intMinimum"></param>
        /// <param name="intMaximum"></param>
        public void SumOfListNumbers(int intMinimum, int intMaximum)
        {
            int sum = 0;
            List<int> thelistOfInt = new List<int>();




            for (int i = intMinimum; i <= intMaximum; i++)
            {
                Console.WriteLine(" enter the  numbers for list");
                string listinput = Console.ReadLine();
                bool islistinputInteger = int.TryParse(listinput, out int intlistinput);
                if (islistinputInteger)
                {
                    thelistOfInt.Add(intlistinput);
                    sum += intlistinput;
                }
                else
                {
                    Console.WriteLine("plz enter a integer list element ");
                    intMaximum++;
                }

            }
            Console.WriteLine($"sum of values in list :{sum}");
            Thread.Sleep(5000);

        }
        /// <summary>
        ///  takes a sequence of inputs from users and print 
        /// positive even ,negative even , positive odd ,negative odd ,zeros
        /// </summary>
        public void fourthQuestion()
        {
            List<int> numbers = new List<int>();
            try
            {
                while (true)
                {
                    Console.WriteLine(" Enter sequence of numbers         ( when you finish just write 'done')    : ");

                    string listinput = Console.ReadLine();
                    bool islistinputInteger = int.TryParse(listinput, out int intlistinput);
                    if (listinput == "done")
                    {
                        makelogicForfourthQuestion(numbers);
                        break;
                    }
                    else if (islistinputInteger)
                    {
                        numbers.Add(intlistinput);
                    }

                    else
                    {
                        Console.WriteLine("plz add an intger only ");
                    };

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error {ex}");
            }


        }
        /// <summary>
        /// here i make the logic for the counting program to know how many from each catg i have in my list numbers 
        /// </summary>
        /// <param name="numbers"></param>
        public void makelogicForfourthQuestion(List<int> numbers)
        {
            int positiveOdd = 0;
            int negativeOdd = 0;
            int positiveEven = 0;
            int negativeEven = 0;
            int zeros = 0;

            foreach (int number in numbers)
            {
                if (number > 0 && number % 2 != 0)
                {
                    positiveOdd++;
                    // check and number of positive odd numbers

                }
                else if (number < 0 && number % 2 != 0)
                {
                    negativeOdd++;
                    // check number of negative odd numbers

                }
                else if (number > 0 && number % 2 == 0)
                {
                    positiveEven++;
                    //check number of positive even numbers

                }
                else if (number < 0 && number % 2 == 0)
                {
                    negativeEven++;
                    // check number of negative odd numbers 

                }
                zeros += (number == 0) ? 1 : 0;
                //check Number of zeros

            }
            Console.WriteLine($"Number of positive even numbers: {positiveEven}\r\n\r\n" +
                $"Number of negative even numbers:{negativeEven}\r\n\r\n" +
                $"Number of positive odd numbers:{positiveOdd}\r\n\r\n" +
                $"Number of negative odd numbers:{negativeOdd}\r\n\r\n" +
                $"Number of zeros:{zeros}");
            Thread.Sleep(10000);


        }
    }

}


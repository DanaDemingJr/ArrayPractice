using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array
            //DataType[] nameOfArray = { elements };
            //int[] myArray = { 1, 2, 3, 4, 5, 6 };
            //string[] students = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            //Console.WriteLine(students[4]);

            //string[] topVactionSpots = { "Orlando", "Miami", "Las Vegas", "San Diego", "Ibiza", "Key West", "Mexico", "Ireland", "Tampa Bay", "Rome" };
            //Console.WriteLine(topVactionSpots[0]);
            //Console.WriteLine(topVactionSpots[9]);
            ////or
            //Console.WriteLine(topVactionSpots[topVactionSpots.Length-1]);

            //int[] childrensAges = { 5, 14, 3 };
            //Console.WriteLine(childrensAges[0]);
            //Console.WriteLine(childrensAges[1]);
            //Console.WriteLine(childrensAges[2]);

            //when you don't know the elements of your array up front
            //dataType[] nameOfArray = new dataType[#ofElements];
            //the following is declaring, not initializing
            //float[] studentGPA = new float [8];
            //gpa[0] = 4.0f;
            //gpa[1] = 3.5f;

            //char[] peers = { 'R', 'S', 'A' };
            //Console.WriteLine(peers);

            //Declare and initialize an array for the days of the week
            string[] daysOfTheWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            //Declare and initialize an array of student ages using the New keyword
            int[] studentAges = new int[5];
            studentAges[0] = 24;
            studentAges[1] = 25;
            studentAges[2] = 19;
            studentAges[3] = 35;
            studentAges[4] = 42;

            //Console.WriteLine(daysOfTheWeek.Length);
            //Console.WriteLine(daysOfTheWeek[0]);
            //daysOfTheWeek.SetValue("Funday", 0);
            //Console.WriteLine(daysOfTheWeek[0]);
            //string[] birthMonths = { "December", "July", "May", "July" };
            //Console.WriteLine(Array.IndexOf(birthMonths, "July"));
            //Console.WriteLine(Array.LastIndexOf(birthMonths,"July"));


            //int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            //Console.WriteLine(numbers[0]);
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);
            //Array.Sort(numbers);
            //Console.WriteLine(numbers[numbers.Length-1]);


            string[] firstNames = { "Dana", "Frank", "Tom", "Mark", "Charlie" };
            Console.WriteLine(Array.IndexOf(firstNames, "Tom"));

            //or
            string[] firstName = new string[5];
            firstName[0] = "Dana";
            firstName[1] = "Frank";
            firstName[2] = "Tom";
            firstName[3] = "Mark";
            firstName[4] = "Charlie";
            Console.WriteLine(Array.IndexOf(firstName,"Charlie"));

            int[] luckyNumbers = { 3, 7, 5, 23, 43, 5, 7, 43, 23, 3 };
            Console.WriteLine(Array.LastIndexOf(luckyNumbers, 7));

            char[] alphaCharacters = { 'S', 'C', 'G', 'B', 'Z', 'T' };
            Console.WriteLine(alphaCharacters[0]);
            Array.Reverse(alphaCharacters);
            Console.WriteLine(alphaCharacters[0]);

            string[] studentNames = { "Dana", "Ric", "Stacey", "Amy", "Elizabeth", "Ian" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]);
            Console.WriteLine(studentNames[studentNames.Length-1]);

            int[] favoriteNumbers = { 7, 23, 5, 8, 10, 9, 77, 15, 33, 44 };
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers[0]);
            Console.WriteLine(favoriteNumbers[favoriteNumbers.Length-1]);

 
            
            



        }
    }
}

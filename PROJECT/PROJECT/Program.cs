using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name, city;
            double per;
       
            Console.WriteLine("Enter Your Name");
            name = Console.ReadLine();

            Console.WriteLine("Enter Your City");
            city = Console.ReadLine();

            Console.WriteLine("Enter Your Percentage");
            per = Convert.ToDouble(Console.ReadLine());

        string[,] UniversityNames = new string[26, 2]
            {    
                //KARACHI UNIVERSITIES:

                {"NED University","Aga Khan University"},
                {"Karachi University","Dawood University of Engineering and Technology"},
                {"Jinnah University for Women", "Shaheed Zulfiqar Ali Bhutto Institute of Science and Technology"},
                {"Habib University","Ziauddin University"},
                {"Bahria University","Institute of Business Management"},
                {"Karachi Institute of Economics and Technology","Iqra University"},
                {"Textile Institute of Pakistan","Sir Syed University of Engineering and Technology"},
                {"FAST University","DHA Suffa University"},
               
                //LAHORE UNIVERSITIES:

                {"University of Management Sciences","University of the Punjab"},
                {"The University of Lahore","University of Management and Technology"},
                {"University of Central Punjab","University of Health Sciences"},
                {"Hajvery University","University of Veterinary and Animal Sciences"},
                {"Lahore Leads University","Qarshi University"},

                //FAISALABAD UNIVERSITIES:

                {"The University of Faisalabad","University of Agriculture"},
                {"Government College University Faisalabad","National Textile University"},
                {"Government College Women University","Faisalabad Medical University"},

                //ISLAMABAD UNIVERSITIES:
                {"COMSATS Institute of Information Technology","Air University"},
                {"Institute of Space Technology","National Defence University"},
                {"International Islamic University","National University of Sciences and Technology"},
                {"Quaid-i-Azam University","Riphah International University"},
                {"Shaheed Zulfiqar Ali Bhutto Medical University","Pakistan Institute of Engineering and Applied Sciences"},

                //PESHAWAR UNIVERSITIES:
                {"CECOS University","University of Peshawar"},
                {"Abasyn University","Khyber Medical University"},
                {"University of Engineering and Technology","Gandhara University"},
                {"Sarhad University of Science and Information Technology","Islamia College University"},
                {"City University of Science and Information Technology","Khyber Pakhtunkhwa Agricultural University"},
            };

            Console.WriteLine("\nYou Are Applicable In These Universities\n------------------------------------------");
           
            // FOR KARACHI:

            for (int i = 0; i < UniversityNames.Length; i++)
            {
                if  (per >= 80 && city == "karachi" || city == "Karachi")
                {
                    Console.WriteLine("1. " + UniversityNames[0, 0]);
                    Console.WriteLine("2. " + UniversityNames[0, 1]);
                    Console.WriteLine("3. " + UniversityNames[1, 0]);
                    break;
                }
                else if (per >= 70 && per < 80 && city == "karachi" || city == "Karachi")
                {
                    Console.WriteLine("1. " + UniversityNames[1, 1]);
                    Console.WriteLine("1. " + UniversityNames[2, 0]);
                    Console.WriteLine("2. " + UniversityNames[2, 1]);
                    Console.WriteLine("3. " + UniversityNames[3, 0]);
                    break;
                }
                else if (per >= 60 && per < 70 && city == "karachi" || city == "Karachi")
                {
                    Console.WriteLine("1. " + UniversityNames[3, 1]);
                    Console.WriteLine("2. " + UniversityNames[13, 1]);
                    Console.WriteLine("3. " + UniversityNames[14, 1]);
                    break;
                }
            }
            //FOR LAHORE:
            for (int i = 0; i < UniversityNames.Length; i++)
            {
                if (per >= 80 && city == "lahore" || city == "Lahore")
                {
                    Console.WriteLine("1. " + UniversityNames[14, 1]);
                    Console.WriteLine("2. " + UniversityNames[15, 1]);
                    Console.WriteLine("3. " + UniversityNames[16, 1]);
                    break;
                }
                else if (per >= 70 && per < 80 && city == "lahore" || city == "Lahore")
                {
                    Console.WriteLine("1. " + UniversityNames[0, 0]);
                    Console.WriteLine("2. " + UniversityNames[1, 1]);
                    Console.WriteLine("3. " + UniversityNames[2, 1]);
                    Console.WriteLine("4. " + UniversityNames[2, 1]);
                    break;
                }
                else if (per >= 60 && per < 70 && city == "lahore" || city == "Lahore")
                {
                    Console.WriteLine("1. " + UniversityNames[1, 1]);
                    Console.WriteLine("2. " + UniversityNames[1, 1]);
                    Console.WriteLine("3. " + UniversityNames[2, 1]);
                    Console.WriteLine("4. " + UniversityNames[2, 1]);
                    break;
                }
            }

        }
    }
}

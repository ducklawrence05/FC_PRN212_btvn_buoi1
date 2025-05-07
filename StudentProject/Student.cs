using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double AverageScore { get; set; }

        public Student() { }

        public Student(string id, string name, double averageScore)
        {
            Id = id;
            Name = name;
            AverageScore = averageScore;
        }

        public bool InputInfo()
        {
            Console.WriteLine("-----------");

            Console.Write("Enter student id: ");
            string idRaw = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(idRaw))
            {
                Console.WriteLine("Id is required");
                return false;
            }

            Console.Write("Enter student name: ");
            string nameRaw = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nameRaw))
            {
                Console.WriteLine("Name is required");
                return false;
            }

            Console.Write("Enter student average score: ");
            if(!double.TryParse(Console.ReadLine(), out double scoreRaw) 
                || scoreRaw < 0 || scoreRaw > 10)
            {
                Console.WriteLine("Invalid score");
                return false;
            }

            Id = idRaw;
            Name = nameRaw;
            AverageScore = scoreRaw;

            Console.WriteLine("Input successfully");
            return true;
        }

        public void OutputInfo()
        {
            Console.WriteLine("----Student information----");
            Console.WriteLine("Id           : " + Id);
            Console.WriteLine("Name         : " + Name);
            Console.WriteLine("Average score: " + AverageScore);
        }

        public string Ranking()
        {
            if (AverageScore >= 9)
            {
                return "Xuat sac";
            }
            else if (AverageScore >= 8)
            {
                return "Gioi";
            }
            else if (AverageScore >= 7)
            {
                return "Kha";
            }
            else if (AverageScore >= 5)
            {
                return "Trung binh";
            }
            else
            {
                return "Yeu";
            }
        }
    }
}

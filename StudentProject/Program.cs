namespace StudentProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[3]
            {
                new Student("SE1234", "Haha", 8.7),
                new Student("SE0987", "Hehe", 6.7),
                new Student()
            };

            bool isCheck = students[2].InputInfo();
            if (isCheck) students[2].OutputInfo();

            Console.WriteLine("----Ranking----");
            for (int i = 0; i < students.Length; i++)
            {
                if (!isCheck && i == students.Length - 1)
                {
                    break;
                }
                Console.WriteLine("{0,-10}: {1}", students[i].Name, students[i].Ranking());
            }
        }
    }
}
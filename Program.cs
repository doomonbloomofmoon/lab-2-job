namespace Lab_2_indTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Worker prolet = new Worker();
            prolet.OutInfo();

            Console.WriteLine();
            
            prolet = new Worker("Черноволов", "Дмитрий", "Александрович", 20);
            prolet.WorkExperience = 1;
            prolet.OutInfo();
            
            Console.WriteLine();
            
            prolet.Positions.Add("Программист");
            prolet.WorkExperience = 5;
            prolet.Age = 24;
            prolet.OutInfo();
            */

            Worker prolet = new Worker();
            prolet.OutAge();
            prolet.OutAge(28, 02, 2003);
        }
    }
}


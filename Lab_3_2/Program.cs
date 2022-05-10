using static System.Console;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vacation[] rec = Vacation.GetVacations();
            for (int i = 0; i < rec.Length; i++)
            {
                WriteLine($"{i + 1}. {rec[i]}");
                WriteLine();
            }
            WriteLine("Choose preferred tour or type 0 to search for new recommendations...");
            int choice = Convert.ToInt32(ReadLine());
            Vacation.ChooseVacation(rec, choice);
            ReadKey();
        }
    }
}
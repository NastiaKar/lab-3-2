using static System.Console;

namespace Lab_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vacation[] rec = VacationWorker.VacationSorting(VacationWorker.GetVacations());
            VacationWorker.PrintVacations(rec);
            WriteLine("Choose preferred tour or type 0 to search for new recommendations...");
            int choice = Convert.ToInt32(ReadLine());
            if (choice != 0)
                VacationWorker.ChooseVacation(rec, choice);
            while (choice == 0)
            {
                var rec2 = VacationWorker.VacationSorting(VacationWorker.VacationParameters());
                VacationWorker.PrintVacations(rec2);
                WriteLine("CHOOSE: ");
                choice = Convert.ToInt32(ReadLine());
                VacationWorker.ChooseVacation(rec2, choice);
            }
            ReadKey();
        }
    }
}
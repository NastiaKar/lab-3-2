using static System.Console;

namespace Lab_3_2;

public class VacationWorker
{
    public static Vacation[] GetVacations()
    {
        Vacation[] rec = new Vacation[5];
        for (int i = 0; i < rec.Length; i++)
            rec[i] = new Vacation();
        return rec;
    }

    public static Vacation[] GetVacations(int days, string transport, bool meals)
    {
        Vacation[] rec = new Vacation[5];
        for (int i = 0; i < rec.Length; i++)
            rec[i] = new Vacation(transport, days, meals);
        return rec;
    }

    public static void ChooseVacation(Vacation[] rec, int i)
    {
        if (i == 0) return;
        Clear();
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("Your vacation: ");
        WriteLine(rec[i - 1]);
        ResetColor();
    }

    public static Vacation[] VacationParameters()
    {
        Clear();
        Write("Choose number of days (5 to 21): ");
        int numOfDays = Convert.ToInt32(ReadLine());
        WriteLine("Choose transport type: ");
        for (int i = 0; i < Vacation.TransportTypes.Length; i++)
            WriteLine($"{i + 1}. {Vacation.TransportTypes[i]}");
        string tType = Vacation.TransportTypes[Convert.ToInt32(ReadLine()) - 1];
        WriteLine("Include meals? (y/n)");
        string meals = ReadLine();
        bool meal = meals == "y";
        Vacation[] recChosen = GetVacations(numOfDays, tType, meal);
        return recChosen;
    }

    public static void PrintVacations(Vacation[] rec)
    {
        for (int i = 0; i < rec.Length; i++)
        {
            WriteLine($"{i + 1}. {rec[i]}");
            WriteLine();
        }
    }

    public static Vacation[] VacationSorting(Vacation[] vac)
    {
        return vac.OrderByDescending(x => x.Rating.Length).ToArray();
    }
}
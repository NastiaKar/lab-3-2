using System.Diagnostics;
using static System.Console;

namespace Lab_3_2;

public class Vacation
{
    public bool MealsAvailable = false;
    private readonly string[] _countriesChoice = new string[] { "USA", "Canada", "Germany", "Ukraine", "France", "Italy"};
    private readonly string[] _vacationType = new string[] { "Relaxation", "Tour", "Health Treatment", "Shopping", "Cruise" };
    private readonly string[] _transportType = new string[] { "Train", "Bus", "Plane", "Ship" };
    private int _numberOfDays;
    private Random rand = new Random();

    public string Country { get; set; }
    public string VacationType { get; set; }
    public string Transport { get; set; }
    public int NumberOfDays
    {
        set
        {
            if (value is > 5 and < 21) _numberOfDays = value;
            else _numberOfDays = 5;
        }
        get => _numberOfDays;
    }

    public Vacation()
    {
        Country = _countriesChoice[rand.Next(_countriesChoice.Length)];
        VacationType = _vacationType[rand.Next(_vacationType.Length)];
        Transport = _transportType[rand.Next(_transportType.Length)];
        NumberOfDays = rand.Next(5, 22);
        MealsAvailable = rand.Next(2) == 1;
    }
    public static Vacation[] GetVacations()
    {
        Vacation[] rec = new Vacation[5];
        for (int i = 0; i < rec.Length; i++)
            rec[i] = new Vacation();
        return rec;
    }
    public static void ChooseVacation(Vacation[] rec, int i)
    {
        Clear();
        ForegroundColor = ConsoleColor.Yellow;
        WriteLine("Your vacation: ");
        WriteLine(rec[i - 1]);
        ResetColor();
    }
    public override string ToString()
    {
        return $"Country: {Country}\nType: {VacationType}\nTransport: {Transport}\nNumber of days: {NumberOfDays}\n" +
               $"Meals: {MealsAvailable}";
    }
}
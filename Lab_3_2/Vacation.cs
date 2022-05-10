using System.Diagnostics;
using static System.Console;

namespace Lab_3_2;

public class Vacation
{
    public static readonly string[] CountriesChoice = new string[] { "USA", "Canada", "Germany", "Ukraine", "France", "Italy"};
    public static readonly string[] VacationTypes = new string[] { "Relaxation", "Tour", "Health Treatment", "Shopping", "Cruise" };
    public static readonly string[] TransportTypes = new string[] { "Train", "Bus", "Plane", "Ship" };
    public bool MealsAvailable = false;
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
        Country = CountriesChoice[rand.Next(CountriesChoice.Length)];
        VacationType = VacationTypes[rand.Next(VacationTypes.Length)];
        Transport = TransportTypes[rand.Next(TransportTypes.Length)];
        NumberOfDays = rand.Next(5, 22);
        MealsAvailable = rand.Next(2) == 1;
    }
    public Vacation(string transport, int numberOfDays, bool mealsAvailable)
    {
        Country = CountriesChoice[rand.Next(CountriesChoice.Length)];
        VacationType = VacationTypes[rand.Next(VacationTypes.Length)];
        Transport = transport;
        NumberOfDays = numberOfDays;
        MealsAvailable = mealsAvailable;
    }
    public override string ToString()
    {
        return $"Country: {Country}\nType: {VacationType}\nTransport: {Transport}\nNumber of days: {NumberOfDays}\n" +
               $"Meals: {MealsAvailable}";
    }
}
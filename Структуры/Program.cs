

using System.Globalization;


public class FootballPlayer
{
    public string Surname; 
    public DateTime BirthDate; 
    public string BirthPlace; 
    public string Position; 
    public int GamesPlayed; 
    public int YellowCards; 
} 

public class Program
{
    public static void Main(string[] args)
    {
        List<FootballPlayer> players = new List<FootballPlayer>()
        {
            new FootballPlayer { Surname = "Иванов", BirthDate = new DateTime(2003, 5, 10), BirthPlace = "Москва", Position = "Нападающий", GamesPlayed = 12, YellowCards = 0 },
            new FootballPlayer { Surname = "Петров", BirthDate = new DateTime(2001, 11, 22), BirthPlace = "Санкт-Петербург", Position = "Защитник", GamesPlayed = 15, YellowCards = 2 },
            new FootballPlayer { Surname = "Сидоров", BirthDate = new DateTime(2004, 3, 1), BirthPlace = "Екатеринбург", Position = "Полузащитник", GamesPlayed = 10, YellowCards = 1 },
            new FootballPlayer { Surname = "Смирнов", BirthDate = new DateTime(2000, 7, 8), BirthPlace = "Новосибирск", Position = "Вратарь", GamesPlayed = 8, YellowCards = 0 }
        };


        Console.WriteLine("Футболисты, старше 20 лет и получившие не более 1 карточки за 10 игр:");
        DateTime today = DateTime.Today;
        foreach (var player in players)
        {
            int age = today.Year - player.BirthDate.Year;
            if (player.BirthDate > today.AddYears(-age)) age--; 

            if (age > 20 && player.GamesPlayed >= 10 && player.YellowCards <= 1)
            {
                Console.WriteLine($"Фамилия:{player.Surname}");
                Console.WriteLine($"Дата и место рождения: {player.BirthDate.ToString("dd.MM.yyyy")}");
                Console.WriteLine($"Место рождения:{player.BirthPlace}");
                Console.WriteLine($"Амплуа:{player.Position}");
                Console.WriteLine($"Количество игр:{player.GamesPlayed}");
                Console.WriteLine($"Количество желтых карточек:{player.YellowCards}");
                Console.WriteLine();
            }
        }
    }
}








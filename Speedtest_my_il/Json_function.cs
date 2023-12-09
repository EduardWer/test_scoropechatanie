
using Newtonsoft.Json;

namespace Speedtest_my_il;

public class Json_function
{
    static List<User> Users = new List<User>();
        
    public void Get_json()
    {
        string json = JsonConvert.SerializeObject(Users);
        File.WriteAllText("C:\\Users\\Admin\\Desktop\\Учёба", json);
    }
        
    public void Show_Json()
    {
        foreach (User user in Users)
        {
            Console.WriteLine("Имя: " + user.UserName);
            Console.WriteLine("Скорость в минуту: " + user.Speed_minute);
            Console.WriteLine("Скорость в секунду: " + user.Second);
            Console.WriteLine("                                          ");
        }
    }
        
    public void AddUsers(string name, double minute, double second)
    {
        Users.Add(new User(name, minute, second));

    }
}

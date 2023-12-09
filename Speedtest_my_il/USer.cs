namespace Speedtest_my_il;


public class User
    {
        public string UserName { get; set; }    
        public double Second { get; set; }
        public double Speed_minute { get; set; }
        public User( string name, double minutes, double seconds)
        {
            this.UserName = name;
            this.Speed_minute = minutes;
            this.Second = seconds;
        }
        public User()
        {
            
        }
    }

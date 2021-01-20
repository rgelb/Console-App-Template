namespace ConsoleApp.Settings {
    static public class App {
        public static AppSettings AppSettings { get; set; }
        public static ConnectionStrings ConnectionStrings { get; set; }
    }

    public class AppSettings {
        public string LogPath { get; set; }
    }

    public class ConnectionStrings {
        public string Trio { get; set; }
    }

}

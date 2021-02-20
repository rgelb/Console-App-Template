namespace ConsoleApp.Settings {

    // static container for all App related settings - available at all times
    public static class App {
        public static AppConfig Config { get; set; }
    }

    public class AppConfig {
        public AppSettings AppSettings { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class AppSettings {
        public string SmartlingUserIdentifier { get; set; }
        public string SmartlingUserSecret { get; set; }
        public string SmartlingProjectId { get; set; }
    }

    public class ConnectionStrings {
        public string Trio { get; set; }
    }
}

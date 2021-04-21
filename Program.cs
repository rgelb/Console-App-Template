using CommandLine;
using ConsoleApp.CommandLine;
using ConsoleApp.Settings;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace ConsoleApp {
    class Program {
        static void Main(string[] args) {
            InitializeSettings();

            Parser.Default.ParseArguments<Parameters>(args)
                .WithParsed(RunApplication)
                .WithNotParsed(HandleCommandLineError);
        }

        private static void RunApplication(Parameters parameters) {
            Console.WriteLine("Hello World!");
        }

        private static void HandleCommandLineError(IEnumerable<Error> errs) {
            foreach (var err in errs) {
                Console.WriteLine($"{err.Tag}");
            }
        }

        private static void InitializeSettings() {
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true)
                .AddEnvironmentVariables();

            var config = builder.Build();
            App.Config = config.Get<AppConfig>();
        }
    }
}

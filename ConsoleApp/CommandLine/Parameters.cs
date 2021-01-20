using CommandLine;

namespace ConsoleApp.CommandLine {
    public class Parameters {
        [Option('v', "verbose", Required = false, HelpText = "Set output to verbose messages.")]
        public bool Verbose { get; set; }
    }
}

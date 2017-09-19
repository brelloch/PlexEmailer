using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace PlexEmailer.Utils
{
    class Options {
        [Option('t', "token", Required = true,
            HelpText = "Plex Token.")]
        public string Token { get; set; }
    
        [Option('u', "url", Required = true,
            HelpText = "Plex URL. Example: http://localhost:32400/")]
        public string Url { get; set; }

        [Option('f', "from", Required = true,
            HelpText = "From Email Address")]
        public string From { get; set; }

        [Option('e', "to", Required = true,
            HelpText = "To Email Addresses")]
        public string Emails { get; set; }

        [Option('p', "password", Required = true,
            HelpText = "Password for Email Address")]
        public string Password { get; set; }
        
        [Option('q', "quiet", DefaultValue = false,
            HelpText = "Do not send email if true")]
        public bool Quiet { get; set; }

        [Option('v', "verbose", DefaultValue = true,
            HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        [HelpOption]
        public string GetUsage() {
            return HelpText.AutoBuild(this,
                (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}

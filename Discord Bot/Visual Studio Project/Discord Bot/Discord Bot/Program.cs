using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;


namespace Discord_Bot
{
    public class Program
    {

        public static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        public async Task MainAsync()
        {
            string token = "MzI4MDM1OTA2NTU0NDI5NDQ0.DJH32w.gP2qdCGhI2coMLIAwxSSDkvMt04";

            _client = new DiscordSocketClient();
            _client.Log += Log;

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();
            
            _client.MessageReceived += MessageReceived;

            string input;
            do
            {
                input = Console.ReadLine();
            }
            while (input != "exit");

            await _client.StopAsync();
            await _client.LogoutAsync();            
        }

        private Task _client_LoggedOut()
        {
            throw new NotImplementedException();
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        public String GetCommands(String[][] cmds)
        {
            String _return = "This bot has the following commands: \n";

            for (int i = 0; i < cmds.Length; i++)
            {
                _return += cmds[i][0];
                _return += "\n";
            }

            return _return;
        }

        private async Task MessageReceived(SocketMessage message)
        {
            String msg = message.Content;
            
            //Text Commands
            String[][] textCmds = new String[][]
            {
                new String[]{"!help",   ""},
                new String[]{"!test",   "Bot is working"},
                new String[]{"!plug",   "https://plug.dj/-9024781283140214337"},
                new String[]{"!poe",    "@Guano wanna play PoE LUL"},
                new String[]{"!no",     "Fuck off Abir"},
                new String[]{"!hello",  "Hi!"}
            };
                        
            //if ( !(msg.Contains(" ")) )
            //{
                int i = textCmds.Length - 1;
                for (; i > -1; i--)
                {
                    if (msg == "!help") textCmds[0][1] = GetCommands(textCmds);
                    if (textCmds[i][0].Contains(msg))
                    {
                        await message.Channel.SendMessageAsync(textCmds[i][1]);
                        String _logMessage = "Issued " + textCmds[i][0] + " command";
                        LogMessage _log = new LogMessage(LogSeverity.Info, "User", _logMessage);
                        await Log(_log);
                        break; //don't think I need a break here lol oh well
                    }
                }
            //};

            //Function Commands
            String[] funcCmds = new String[]
            {
                "!osu",
                "!twitter"
            };
            
            if(msg.StartsWith(funcCmds[0]))
            {
                String _user = msg.Substring(funcCmds[0].Length+1);
                await message.Channel.SendMessageAsync("https://osu.ppy.sh/u/"+_user);
                String _logMessage = "Issued !osu command for "+_user;
                LogMessage _log = new LogMessage(LogSeverity.Info, "User", _logMessage);
                await Log(_log);
            }

            if (msg.StartsWith(funcCmds[1]))
            {
                String _user = msg.Substring(funcCmds[1].Length+1);
                await message.Channel.SendMessageAsync("https://twitter.com/" + _user);
                String _logMessage = "Issued !twitter command for " + _user;
                LogMessage _log = new LogMessage(LogSeverity.Info, "User", _logMessage);
                await Log(_log);
            }

        }

        
    }
}

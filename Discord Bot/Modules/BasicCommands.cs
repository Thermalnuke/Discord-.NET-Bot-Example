using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public class BasicCommands : ModuleBase<SocketCommandContext>
{
    // !ping returns pong!
    [Command("ping")]
    [Summary("Echoes a message.")]
    public Task PingAsync() => ReplyAsync("pong!");

}

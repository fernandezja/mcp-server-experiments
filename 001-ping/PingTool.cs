using ModelContextProtocol.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingMCPServer;

[McpServerToolType]
public static class PingTool
{
    [McpServerTool, Description("Returns the client's messages exactly as they were received, like a ping response.")]
    public static string Ping(string message) => $"Pong! Your message is: {message}";


    [McpServerTool, Description("Sends a simple ping response.")]
    public static string SimplePing() => "Ping received!";


    [McpServerTool, Description("Echoes back the provided message.")]
    public static string Echo(string message) => $"Echo: {message}";


    [McpServerTool, Description("Returns a welcome message.")]
    public static string Welcome() => "Welcome to the echo server!";


    [McpServerTool, Description("Returns the current server time.")]
    public static string GetCurrentTime() => $"Current server time is: {DateTime.Now}";
}

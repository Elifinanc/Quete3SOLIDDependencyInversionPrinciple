using System;

namespace QueteSolid3DIP
{
    public class Program
    {
        public static void Main()
        {
            IExecutable terminal = new Terminal();
            while (!terminal.Exited)
            {
                Command command = terminal.PromptCommand();
                terminal.ExecuteCommand(command);
            }
        }
    }
}

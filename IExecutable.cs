using System;
using System.Collections.Generic;
using System.Text;

namespace QueteSolid3DIP
{
    public interface IExecutable
    {
        public bool Exited { get; set; }
        public Command PromptCommand();
        public string Prompt();
        public void ExecuteCommand(Command command);

    }
}
